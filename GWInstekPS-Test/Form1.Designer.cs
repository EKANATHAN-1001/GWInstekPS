namespace GWInstekPS_Test
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
            this.Connect = new System.Windows.Forms.Button();
            this.IsConnect = new System.Windows.Forms.Button();
            this.Signal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.TextBox();
            this.SetCurrent = new System.Windows.Forms.Button();
            this.SetVoltage = new System.Windows.Forms.Button();
            this.Voltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputEnable = new System.Windows.Forms.Button();
            this.OutputDisable = new System.Windows.Forms.Button();
            this.OutputStatus = new System.Windows.Forms.Label();
            this.SetOCP = new System.Windows.Forms.Button();
            this.SetOVP = new System.Windows.Forms.Button();
            this.GetOCP = new System.Windows.Forms.Button();
            this.GetOVP = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.ReadVoltage = new System.Windows.Forms.Button();
            this.ReadCurrent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(199, 120);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(101, 31);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // IsConnect
            // 
            this.IsConnect.Location = new System.Drawing.Point(68, 52);
            this.IsConnect.Name = "IsConnect";
            this.IsConnect.Size = new System.Drawing.Size(101, 31);
            this.IsConnect.TabIndex = 1;
            this.IsConnect.Text = "IsConnect";
            this.IsConnect.UseVisualStyleBackColor = true;
            this.IsConnect.Click += new System.EventHandler(this.IsConnect_Click);
            // 
            // Signal
            // 
            this.Signal.AutoSize = true;
            this.Signal.Location = new System.Drawing.Point(337, 129);
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(74, 13);
            this.Signal.TabIndex = 2;
            this.Signal.Text = "DisConnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current :";
            // 
            // Current
            // 
            this.Current.Location = new System.Drawing.Point(65, 44);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(132, 20);
            this.Current.TabIndex = 4;
            // 
            // SetCurrent
            // 
            this.SetCurrent.Location = new System.Drawing.Point(38, 84);
            this.SetCurrent.Name = "SetCurrent";
            this.SetCurrent.Size = new System.Drawing.Size(66, 31);
            this.SetCurrent.TabIndex = 5;
            this.SetCurrent.Text = "SetCurrent";
            this.SetCurrent.UseVisualStyleBackColor = true;
            this.SetCurrent.Click += new System.EventHandler(this.SetCurrent_Click);
            // 
            // SetVoltage
            // 
            this.SetVoltage.Location = new System.Drawing.Point(119, 84);
            this.SetVoltage.Name = "SetVoltage";
            this.SetVoltage.Size = new System.Drawing.Size(70, 31);
            this.SetVoltage.TabIndex = 8;
            this.SetVoltage.Text = "SetVoltage";
            this.SetVoltage.UseVisualStyleBackColor = true;
            this.SetVoltage.Click += new System.EventHandler(this.SetVoltage_Click);
            // 
            // Voltage
            // 
            this.Voltage.Location = new System.Drawing.Point(262, 44);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(132, 20);
            this.Voltage.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voltage :";
            // 
            // OutputEnable
            // 
            this.OutputEnable.Location = new System.Drawing.Point(26, 90);
            this.OutputEnable.Name = "OutputEnable";
            this.OutputEnable.Size = new System.Drawing.Size(83, 31);
            this.OutputEnable.TabIndex = 9;
            this.OutputEnable.Text = "OutputEnable";
            this.OutputEnable.UseVisualStyleBackColor = true;
            this.OutputEnable.Click += new System.EventHandler(this.OutputEnable_Click);
            // 
            // OutputDisable
            // 
            this.OutputDisable.Location = new System.Drawing.Point(26, 127);
            this.OutputDisable.Name = "OutputDisable";
            this.OutputDisable.Size = new System.Drawing.Size(85, 31);
            this.OutputDisable.TabIndex = 10;
            this.OutputDisable.Text = "OutputDisable";
            this.OutputDisable.UseVisualStyleBackColor = true;
            this.OutputDisable.Click += new System.EventHandler(this.OutputDisable_Click);
            // 
            // OutputStatus
            // 
            this.OutputStatus.AutoSize = true;
            this.OutputStatus.Location = new System.Drawing.Point(134, 99);
            this.OutputStatus.Name = "OutputStatus";
            this.OutputStatus.Size = new System.Drawing.Size(48, 13);
            this.OutputStatus.TabIndex = 11;
            this.OutputStatus.Text = "Disabled";
            // 
            // SetOCP
            // 
            this.SetOCP.Location = new System.Drawing.Point(302, 84);
            this.SetOCP.Name = "SetOCP";
            this.SetOCP.Size = new System.Drawing.Size(70, 31);
            this.SetOCP.TabIndex = 13;
            this.SetOCP.Text = "SetOCP";
            this.SetOCP.UseVisualStyleBackColor = true;
            this.SetOCP.Click += new System.EventHandler(this.SetOCP_Click);
            // 
            // SetOVP
            // 
            this.SetOVP.Location = new System.Drawing.Point(219, 84);
            this.SetOVP.Name = "SetOVP";
            this.SetOVP.Size = new System.Drawing.Size(66, 31);
            this.SetOVP.TabIndex = 12;
            this.SetOVP.Text = "SetOVP";
            this.SetOVP.UseVisualStyleBackColor = true;
            this.SetOVP.Click += new System.EventHandler(this.SetOVP_Click);
            // 
            // GetOCP
            // 
            this.GetOCP.Location = new System.Drawing.Point(302, 145);
            this.GetOCP.Name = "GetOCP";
            this.GetOCP.Size = new System.Drawing.Size(70, 31);
            this.GetOCP.TabIndex = 15;
            this.GetOCP.Text = "GetOCP";
            this.GetOCP.UseVisualStyleBackColor = true;
            this.GetOCP.Click += new System.EventHandler(this.GetOCP_Click);
            // 
            // GetOVP
            // 
            this.GetOVP.Location = new System.Drawing.Point(219, 145);
            this.GetOVP.Name = "GetOVP";
            this.GetOVP.Size = new System.Drawing.Size(66, 31);
            this.GetOVP.TabIndex = 14;
            this.GetOVP.Text = "GetOVP";
            this.GetOVP.UseVisualStyleBackColor = true;
            this.GetOVP.Click += new System.EventHandler(this.GetOVP_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(370, 413);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(10, 13);
            this.Result.TabIndex = 16;
            this.Result.Text = " ";
            // 
            // ReadVoltage
            // 
            this.ReadVoltage.Location = new System.Drawing.Point(119, 145);
            this.ReadVoltage.Name = "ReadVoltage";
            this.ReadVoltage.Size = new System.Drawing.Size(85, 31);
            this.ReadVoltage.TabIndex = 18;
            this.ReadVoltage.Text = "ReadVoltage";
            this.ReadVoltage.UseVisualStyleBackColor = true;
            this.ReadVoltage.Click += new System.EventHandler(this.ReadVoltage_Click);
            // 
            // ReadCurrent
            // 
            this.ReadCurrent.Location = new System.Drawing.Point(38, 145);
            this.ReadCurrent.Name = "ReadCurrent";
            this.ReadCurrent.Size = new System.Drawing.Size(75, 31);
            this.ReadCurrent.TabIndex = 17;
            this.ReadCurrent.Text = "ReadCurrent";
            this.ReadCurrent.UseVisualStyleBackColor = true;
            this.ReadCurrent.Click += new System.EventHandler(this.ReadCurrent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Baud Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "COM Port :";
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
            this.COMPortComboBox.Location = new System.Drawing.Point(89, 74);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(130, 21);
            this.COMPortComboBox.TabIndex = 23;
            this.COMPortComboBox.SelectedIndexChanged += new System.EventHandler(this.COMPortComboBox_SelectedIndexChanged);
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(321, 74);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(130, 21);
            this.BaudRateComboBox.TabIndex = 24;
            this.BaudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.BaudRateComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Source Code Path : ";
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(121, 39);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(339, 20);
            this.SourcePath.TabIndex = 26;
            this.SourcePath.Text = "D:\\Procyon\\C# Migration\\C# Migration (Plugin)\\ProjectCode_Project\\Template_Source" +
    "Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SourcePath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BaudRateComboBox);
            this.panel1.Controls.Add(this.Signal);
            this.panel1.Controls.Add(this.COMPortComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Location = new System.Drawing.Point(30, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 155);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ReadVoltage);
            this.panel2.Controls.Add(this.ReadCurrent);
            this.panel2.Controls.Add(this.GetOCP);
            this.panel2.Controls.Add(this.GetOVP);
            this.panel2.Controls.Add(this.SetOCP);
            this.panel2.Controls.Add(this.SetOVP);
            this.panel2.Controls.Add(this.SetVoltage);
            this.panel2.Controls.Add(this.Voltage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SetCurrent);
            this.panel2.Controls.Add(this.Current);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(76, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 194);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.OutputStatus);
            this.panel3.Controls.Add(this.OutputDisable);
            this.panel3.Controls.Add(this.OutputEnable);
            this.panel3.Controls.Add(this.IsConnect);
            this.panel3.Location = new System.Drawing.Point(574, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 173);
            this.panel3.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "CONNECTING  PANEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "CONFIGURE  PANEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "STATUS PANEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button IsConnect;
        private System.Windows.Forms.Label Signal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Current;
        private System.Windows.Forms.Button SetCurrent;
        private System.Windows.Forms.Button SetVoltage;
        private System.Windows.Forms.TextBox Voltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OutputEnable;
        private System.Windows.Forms.Button OutputDisable;
        private System.Windows.Forms.Label OutputStatus;
        private System.Windows.Forms.Button SetOCP;
        private System.Windows.Forms.Button SetOVP;
        private System.Windows.Forms.Button GetOCP;
        private System.Windows.Forms.Button GetOVP;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ReadVoltage;
        private System.Windows.Forms.Button ReadCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

