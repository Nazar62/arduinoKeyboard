using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;

namespace Arduino
{
    public partial class Form1 : Form
    {
        string recievedData = "";
        Settings settings;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void UpdatePortsListBtn_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COMcomboBox.Text = "";
            COMcomboBox.Items.Clear();
            if (ports.Length != 0)
            {
                COMcomboBox.Items.AddRange(ports);
                COMcomboBox.SelectedIndex = 0;
                ConnectBtn.Enabled = true;
                COMcomboBox.Enabled = true;
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
                try
                {
                    serialPorts.PortName = COMcomboBox.SelectedItem.ToString();
                    serialPorts.Open();
                } catch
                {
                    MessageBox.Show("Connection Error");
                }
            ConnectBtn.Enabled = false;
            hotkey1.Enabled = false;
            hotkey2.Enabled = false;
            hotkey3.Enabled = false;
            SaveBtn.Enabled = false;
            COMcomboBox.Enabled = false;
            UnconnectBtn.Enabled = true;
            timer.Start();
        }
        string data = "";
        private void serialPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPorts.ReadLine();
            recievedText.Text = data;
        }

        private void UnconnectBtn_Click(object sender, EventArgs e)
        {
            serialPorts.Close();
            timer.Stop();
            ConnectBtn.Enabled = true;
            COMcomboBox.Enabled = true;
            UnconnectBtn.Enabled = false;
            hotkey1.Enabled = true;
            hotkey2.Enabled = true;
            hotkey3.Enabled = true;
            SaveBtn.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (data.Contains("1"))
            {
                SettingsManager.GetSettings();
                data = "";
                send1(settings.hotkeys1);
            }
            if (data.Contains("2"))
            {
                settings = SettingsManager.GetSettings();
                data = "";
                send2(settings.hotkeys2);
            }
            if (data.Contains("3"))
            {
                SettingsManager.GetSettings();
                data = "";
                send3(settings.hotkeys3);
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            SettingsManager.GetSettings();
            //Thread.Sleep(1000);
            //SendKeys.Send("^d");
            Thread.Sleep(1000);
            send3(settings.hotkeys3);
        }
        private void send1(string hotkey)
        {
            SendKeys.Send(hotkey);
        }
        private void send2(string hotkey)
        {
            SendKeys.Send(hotkey);
        }
        private void send3(string hotkey)
        {
            SendKeys.Send(hotkey);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPorts.Close();
            timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length != 0)
            {
                COMcomboBox.Items.AddRange(ports);
                COMcomboBox.SelectedIndex = 0;
                ConnectBtn.Enabled = true;
                COMcomboBox.Enabled = true;
            }
            settings = SettingsManager.GetSettings();
            hotkey1.Text = settings.hotkeys1;
            hotkey2.Text = settings.hotkeys2;
            hotkey3.Text = settings.hotkeys3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customCombobox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hotkey1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hotkey2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotkey3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            settings = new Settings
            {
                hotkeys1 = hotkey1.Text,
                hotkeys2 = hotkey2.Text,
                hotkeys3 = hotkey3.Text
            };
            SettingsManager.SaveSettings(settings);
            MessageBox.Show("Saved");
        }
    }
}
