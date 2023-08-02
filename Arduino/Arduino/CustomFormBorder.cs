using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class CustomFormBorder : UserControl
    {
        Button exit;
        Button minimize;
        Button maximize;
        Panel buttonPanel;
        Panel panel;
        int startX;
        int buttonsWidth;
        string formName = "Form1";
        Color panelColor = Color.DimGray;
        Color buttonCollor = Color.DimGray;

        public string FormName { get { return formName; } set { formName = value; } }

        public Color PanelColor { get => panelColor; set => panelColor = value; }
        public Color ButtonCollor { get => buttonCollor; set => buttonCollor = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private FormWindowState WindowState;
        public CustomFormBorder()
        {
            InitializeComponent();


            drawButton();

            this.Size = new Size(this.ClientSize.Width, 32);
            //this.MinimumSize = new Size(this.ClientSize.Width, 32);
            //this.MaximumSize = new Size(this.ClientSize.Width, 32);
            minimize.Click += Minimize_Click;
            maximize.Click += Maximize_Click;
            exit.Click += ExitBtn_Click;
        }

        private void drawButton()
        {
            panel = new Panel();

            panel.Width = this.ClientSize.Width;
            panel.Dock = DockStyle.Fill;
            //panel.SuspendLayout();
            panel.MouseDown += Panel_MouseDown;
            panel.ClientSizeChanged += Panel_ClientSizeChanged;
            this.ClientSizeChanged += CustomFormBorder_ClientSizeChanged;
            this.Controls.Add(panel);

            int buttonWidth = 46;
            int buttonHeight = 32;

            // Calculate the total width required for the buttons
            buttonsWidth = (buttonWidth * 3);

            // Calculate the starting X position for the buttons
            startX = this.ClientSize.Width - buttonsWidth;

            buttonPanel = new Panel();
            buttonPanel.Width = buttonsWidth + 15;
            //buttonPanel.Dock = DockStyle.Right;
            buttonPanel.Location = new Point(startX, 0);
            panel.Controls.Add(buttonPanel);

            minimize = new Button();
            minimize.Size = new Size(46, 32);
            minimize.BackColor = Color.Blue;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.FlatAppearance.BorderSize = 0;
            minimize.Location = new Point(startX, 0);
            buttonPanel.Controls.Add(minimize);

                maximize = new Button();
                maximize.Size = new Size(46, 32);
                maximize.BackColor = Color.White;
                maximize.FlatStyle = FlatStyle.Flat;
                maximize.FlatAppearance.BorderSize = 0;
                maximize.Location = new Point(minimize.Right, 0);//(this.ClientSize.Height - buttonHeight) / 2);
                buttonPanel.Controls.Add(maximize);

            exit = new Button();
            exit.BackColor = Color.Red;
            exit.Size = new Size(46, 32);
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.Location = new Point(maximize.Right, 0);
            exit.FlatAppearance.MouseDownBackColor = Color.Red;
            exit.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            buttonPanel.Controls.Add(exit);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void CustomFormBorder_ClientSizeChanged(object sender, EventArgs e)
        {
            startX = this.ClientSize.Width - buttonsWidth;
            panel.Width = this.ClientSize.Width;
            buttonPanel.Location = new Point(startX -15, 0);
        }

        private void Panel_ClientSizeChanged(object sender, EventArgs e)
        {
            startX = this.ClientSize.Width - buttonsWidth;
            panel.Width = this.ClientSize.Width;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[formName];
            if (form.WindowState != FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            } else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;
            Form form = Application.OpenForms[formName];
            form.WindowState = FormWindowState.Minimized;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
// ідея перемістити кнопки в panel з totalwidth шириною і його вже засунути в інший panel