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
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (data.Contains("1"))
            {
                data = "";
                sendMicrophone();
            }
            if (data.Contains("2"))
            {
                data = "";
                sendHand();
            }
            if (data.Contains("3"))
            {
                data = "";
                sendCam();
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            //SendKeys.Send("^d");
            Thread.Sleep(1000);
            sendHand();
        }
        private void sendMicrophone()
        {
            SendKeys.Send("^d");
        }
        private void sendHand()
        {
            SendKeys.Send("^%h");
        }
        private void sendCam()
        {
            SendKeys.Send("^e");
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
    }
}
