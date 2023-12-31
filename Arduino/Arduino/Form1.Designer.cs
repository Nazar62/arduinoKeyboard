﻿
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
            this.hotkey1 = new System.Windows.Forms.TextBox();
            this.COMcomboBox = new Arduino.CustomCombobox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hotkey2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotkey3 = new System.Windows.Forms.TextBox();
            this.customFormBorderMini1 = new Arduino.CustomFormBorderMini();
            this.SaveBtn = new Arduino.CustomButton();
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
            this.recievedText.Location = new System.Drawing.Point(195, 69);
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
            // hotkey1
            // 
            this.hotkey1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hotkey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotkey1.Location = new System.Drawing.Point(12, 48);
            this.hotkey1.Name = "hotkey1";
            this.hotkey1.Size = new System.Drawing.Size(131, 20);
            this.hotkey1.TabIndex = 7;
            this.hotkey1.TextChanged += new System.EventHandler(this.hotkey1_TextChanged);
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Hot key 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hot key 2";
            // 
            // hotkey2
            // 
            this.hotkey2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hotkey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotkey2.Location = new System.Drawing.Point(12, 87);
            this.hotkey2.Name = "hotkey2";
            this.hotkey2.Size = new System.Drawing.Size(131, 20);
            this.hotkey2.TabIndex = 12;
            this.hotkey2.TextChanged += new System.EventHandler(this.hotkey2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hot key 3";
            // 
            // hotkey3
            // 
            this.hotkey3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hotkey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotkey3.Location = new System.Drawing.Point(12, 126);
            this.hotkey3.Name = "hotkey3";
            this.hotkey3.Size = new System.Drawing.Size(131, 20);
            this.hotkey3.TabIndex = 14;
            this.hotkey3.TextChanged += new System.EventHandler(this.hotkey3_TextChanged);
            // 
            // customFormBorderMini1
            // 
            this.customFormBorderMini1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customFormBorderMini1.ButtonCollor = System.Drawing.Color.DimGray;
            this.customFormBorderMini1.FormName = "Form1";
            this.customFormBorderMini1.IconColor = System.Drawing.Color.Black;
            this.customFormBorderMini1.IconSize = 5;
            this.customFormBorderMini1.Location = new System.Drawing.Point(0, 0);
            this.customFormBorderMini1.Name = "customFormBorderMini1";
            this.customFormBorderMini1.PanelColor = System.Drawing.Color.DimGray;
            this.customFormBorderMini1.Size = new System.Drawing.Size(407, 32);
            this.customFormBorderMini1.TabIndex = 15;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(24, 152);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(79, 22);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(407, 177);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.customFormBorderMini1);
            this.Controls.Add(this.hotkey3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotkey2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.COMcomboBox);
            this.Controls.Add(this.hotkey1);
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
        private System.Windows.Forms.TextBox hotkey1;
        private CustomCombobox COMcomboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hotkey2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hotkey3;
        private CustomFormBorderMini customFormBorderMini1;
        private CustomButton SaveBtn;
    }
}

