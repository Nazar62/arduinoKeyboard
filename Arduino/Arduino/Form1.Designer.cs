
namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPorts = new System.IO.Ports.SerialPort(this.components);
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.UpdatePortsListBtn = new System.Windows.Forms.Button();
            this.recievedText = new System.Windows.Forms.Label();
            this.UnconnectBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Test = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hotkey1 = new System.Windows.Forms.TextBox();
            this.COMcomboBox = new Arduino.CustomCombobox();
            this.customFormBorder1 = new Arduino.CustomFormBorder();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPorts
            // 
            this.serialPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPorts_DataReceived);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ConnectBtn.Enabled = false;
            this.ConnectBtn.FlatAppearance.BorderSize = 0;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectBtn.Location = new System.Drawing.Point(320, 35);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // UpdatePortsListBtn
            // 
            this.UpdatePortsListBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UpdatePortsListBtn.FlatAppearance.BorderSize = 0;
            this.UpdatePortsListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePortsListBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdatePortsListBtn.Location = new System.Drawing.Point(284, 93);
            this.UpdatePortsListBtn.Name = "UpdatePortsListBtn";
            this.UpdatePortsListBtn.Size = new System.Drawing.Size(111, 23);
            this.UpdatePortsListBtn.TabIndex = 1;
            this.UpdatePortsListBtn.Text = "Update Ports List";
            this.UpdatePortsListBtn.UseVisualStyleBackColor = false;
            this.UpdatePortsListBtn.Click += new System.EventHandler(this.UpdatePortsListBtn_Click);
            // 
            // recievedText
            // 
            this.recievedText.AutoSize = true;
            this.recievedText.Location = new System.Drawing.Point(10, 38);
            this.recievedText.Name = "recievedText";
            this.recievedText.Size = new System.Drawing.Size(90, 13);
            this.recievedText.TabIndex = 3;
            this.recievedText.Text = "Text from Arduino";
            // 
            // UnconnectBtn
            // 
            this.UnconnectBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UnconnectBtn.Enabled = false;
            this.UnconnectBtn.FlatAppearance.BorderSize = 0;
            this.UnconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnconnectBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UnconnectBtn.Location = new System.Drawing.Point(320, 64);
            this.UnconnectBtn.Name = "UnconnectBtn";
            this.UnconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.UnconnectBtn.TabIndex = 4;
            this.UnconnectBtn.Text = "Unconnect";
            this.UnconnectBtn.UseVisualStyleBackColor = false;
            this.UnconnectBtn.Click += new System.EventHandler(this.UnconnectBtn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Test.FlatAppearance.BorderSize = 0;
            this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Test.Location = new System.Drawing.Point(320, 122);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 5;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.SystemColors.ControlDark;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Controls.Add(this.minimizeBtn);
            this.border.Controls.Add(this.exitBtn);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(407, 25);
            this.border.TabIndex = 6;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(339, -1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(35, 25);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(371, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 25);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hotkey1
            // 
            this.hotkey1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hotkey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotkey1.Location = new System.Drawing.Point(13, 67);
            this.hotkey1.Name = "hotkey1";
            this.hotkey1.Size = new System.Drawing.Size(131, 20);
            this.hotkey1.TabIndex = 7;
            // 
            // COMcomboBox
            // 
            this.COMcomboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.COMcomboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.COMcomboBox.BorderSize = 0;
            this.COMcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.COMcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.COMcomboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.COMcomboBox.IconColor = System.Drawing.Color.Black;
            this.COMcomboBox.ListBackColor = System.Drawing.SystemColors.ControlDark;
            this.COMcomboBox.ListTextColor = System.Drawing.Color.White;
            this.COMcomboBox.Location = new System.Drawing.Point(187, 35);
            this.COMcomboBox.MinimumSize = new System.Drawing.Size(100, 15);
            this.COMcomboBox.Name = "COMcomboBox";
            this.COMcomboBox.Size = new System.Drawing.Size(127, 23);
            this.COMcomboBox.TabIndex = 8;
            this.COMcomboBox.Texts = "";
            // 
            // customFormBorder1
            // 
            this.customFormBorder1.FormName = "Form1";
            this.customFormBorder1.Location = new System.Drawing.Point(156, 139);
            this.customFormBorder1.Name = "customFormBorder1";
            this.customFormBorder1.Size = new System.Drawing.Size(150, 32);
            this.customFormBorder1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(407, 177);
            this.Controls.Add(this.customFormBorder1);
            this.Controls.Add(this.COMcomboBox);
            this.Controls.Add(this.hotkey1);
            this.Controls.Add(this.border);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.UnconnectBtn);
            this.Controls.Add(this.recievedText);
            this.Controls.Add(this.UpdatePortsListBtn);
            this.Controls.Add(this.ConnectBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.border.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPorts;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button UpdatePortsListBtn;
        private System.Windows.Forms.Label recievedText;
        private System.Windows.Forms.Button UnconnectBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox hotkey1;
        private CustomCombobox COMcomboBox;
        private CustomFormBorder customFormBorder1;
    }
}

