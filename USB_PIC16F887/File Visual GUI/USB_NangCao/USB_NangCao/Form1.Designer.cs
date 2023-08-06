namespace USB_NangCao
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_OFF = new System.Windows.Forms.Button();
            this.button_ON = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape_LED = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_SW1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_InforDevice = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PN = new System.Windows.Forms.TextBox();
            this.textBox_VN = new System.Windows.Forms.TextBox();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.textBox_VID = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usbHidPort = new UsbLibrary.UsbHidPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_OFF2 = new System.Windows.Forms.Button();
            this.button_ON2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape_LED2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(299, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Design By Trần Bá Tỵ -19486901";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_OFF);
            this.groupBox3.Controls.Add(this.button_ON);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Location = new System.Drawing.Point(302, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED Control 1";
            // 
            // button_OFF
            // 
            this.button_OFF.Location = new System.Drawing.Point(104, 52);
            this.button_OFF.Name = "button_OFF";
            this.button_OFF.Size = new System.Drawing.Size(75, 23);
            this.button_OFF.TabIndex = 3;
            this.button_OFF.Text = "OFF";
            this.button_OFF.UseVisualStyleBackColor = true;
            this.button_OFF.Click += new System.EventHandler(this.button_OFF_Click_1);
            // 
            // button_ON
            // 
            this.button_ON.Location = new System.Drawing.Point(104, 23);
            this.button_ON.Name = "button_ON";
            this.button_ON.Size = new System.Drawing.Size(75, 23);
            this.button_ON.TabIndex = 2;
            this.button_ON.Text = "ON";
            this.button_ON.UseVisualStyleBackColor = true;
            this.button_ON.Click += new System.EventHandler(this.button_ON_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "LED ON/OFF";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_LED});
            this.shapeContainer1.Size = new System.Drawing.Size(186, 81);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape_LED
            // 
            this.ovalShape_LED.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_LED.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape_LED.Location = new System.Drawing.Point(33, 27);
            this.ovalShape_LED.Name = "ovalShape_LED";
            this.ovalShape_LED.Size = new System.Drawing.Size(47, 45);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SW1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(302, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 56);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch Status";
            // 
            // textBox_SW1
            // 
            this.textBox_SW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox_SW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW1.Location = new System.Drawing.Point(83, 19);
            this.textBox_SW1.Name = "textBox_SW1";
            this.textBox_SW1.ReadOnly = true;
            this.textBox_SW1.Size = new System.Drawing.Size(64, 20);
            this.textBox_SW1.TabIndex = 1;
            this.textBox_SW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Counter (SW)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_InforDevice});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_InforDevice
            // 
            this.toolStripStatusLabel_InforDevice.Name = "toolStripStatusLabel_InforDevice";
            this.toolStripStatusLabel_InforDevice.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel_InforDevice.Text = "Disconnect";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(128, 201);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(90, 23);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit Program";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(107, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "USB (HID) Communication Lab";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_PN);
            this.groupBox1.Controls.Add(this.textBox_VN);
            this.groupBox1.Controls.Add(this.textBox_PID);
            this.groupBox1.Controls.Add(this.textBox_VID);
            this.groupBox1.Controls.Add(this.textBox_Status);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Infomation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "for PIC18F4550";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "for Microchip";
            // 
            // textBox_PN
            // 
            this.textBox_PN.BackColor = System.Drawing.Color.White;
            this.textBox_PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PN.Location = new System.Drawing.Point(105, 131);
            this.textBox_PN.Name = "textBox_PN";
            this.textBox_PN.ReadOnly = true;
            this.textBox_PN.Size = new System.Drawing.Size(169, 20);
            this.textBox_PN.TabIndex = 9;
            this.textBox_PN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_VN
            // 
            this.textBox_VN.BackColor = System.Drawing.Color.White;
            this.textBox_VN.Location = new System.Drawing.Point(105, 105);
            this.textBox_VN.Name = "textBox_VN";
            this.textBox_VN.Size = new System.Drawing.Size(169, 20);
            this.textBox_VN.TabIndex = 8;
            // 
            // textBox_PID
            // 
            this.textBox_PID.BackColor = System.Drawing.Color.White;
            this.textBox_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PID.Location = new System.Drawing.Point(105, 78);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.ReadOnly = true;
            this.textBox_PID.Size = new System.Drawing.Size(73, 20);
            this.textBox_PID.TabIndex = 7;
            this.textBox_PID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_VID
            // 
            this.textBox_VID.BackColor = System.Drawing.Color.White;
            this.textBox_VID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_VID.Location = new System.Drawing.Point(105, 51);
            this.textBox_VID.Name = "textBox_VID";
            this.textBox_VID.ReadOnly = true;
            this.textBox_VID.Size = new System.Drawing.Size(73, 20);
            this.textBox_VID.TabIndex = 2;
            this.textBox_VID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Status
            // 
            this.textBox_Status.BackColor = System.Drawing.Color.Red;
            this.textBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Status.Location = new System.Drawing.Point(105, 23);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(114, 20);
            this.textBox_Status.TabIndex = 2;
            this.textBox_Status.Text = "Disconnected!!";
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vendor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendor ID (HEX)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product ID (HEX)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device Status";
            // 
            // usbHidPort
            // 
            this.usbHidPort.ProductId = 0;
            this.usbHidPort.VendorId = 0;
            this.usbHidPort.OnSpecifiedDeviceArrived += new System.EventHandler(this.usbHidPort_OnSpecifiedDeviceArrived);
            this.usbHidPort.OnSpecifiedDeviceRemoved += new System.EventHandler(this.usbHidPort_OnSpecifiedDeviceRemoved);
            this.usbHidPort.OnDeviceArrived += new System.EventHandler(this.usbHidPort_OnDeviceArrived);
            this.usbHidPort.OnDeviceRemoved += new System.EventHandler(this.usbHidPort_OnDeviceRemoved);
            this.usbHidPort.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.usbHidPort_OnDataRecieved);
            this.usbHidPort.OnDataSend += new System.EventHandler(this.usbHidPort_OnDataSend);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_OFF2);
            this.groupBox4.Controls.Add(this.button_ON2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.shapeContainer2);
            this.groupBox4.Location = new System.Drawing.Point(302, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED Control 1";
            // 
            // button_OFF2
            // 
            this.button_OFF2.Location = new System.Drawing.Point(104, 52);
            this.button_OFF2.Name = "button_OFF2";
            this.button_OFF2.Size = new System.Drawing.Size(75, 23);
            this.button_OFF2.TabIndex = 3;
            this.button_OFF2.Text = "OFF";
            this.button_OFF2.UseVisualStyleBackColor = true;
            this.button_OFF2.Click += new System.EventHandler(this.button_OFF2_Click);
            // 
            // button_ON2
            // 
            this.button_ON2.Location = new System.Drawing.Point(104, 23);
            this.button_ON2.Name = "button_ON2";
            this.button_ON2.Size = new System.Drawing.Size(75, 23);
            this.button_ON2.TabIndex = 2;
            this.button_ON2.Text = "ON";
            this.button_ON2.UseVisualStyleBackColor = true;
            this.button_ON2.Click += new System.EventHandler(this.button_ON2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "LED ON/OFF";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_LED2});
            this.shapeContainer2.Size = new System.Drawing.Size(186, 81);
            this.shapeContainer2.TabIndex = 4;
            this.shapeContainer2.TabStop = false;
            // 
            // ovalShape_LED2
            // 
            this.ovalShape_LED2.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_LED2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape_LED2.Location = new System.Drawing.Point(30, 27);
            this.ovalShape_LED2.Name = "ovalShape_LED2";
            this.ovalShape_LED2.Size = new System.Drawing.Size(47, 45);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 332);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "USB NC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_OFF;
        private System.Windows.Forms.Button button_ON;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SW1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_InforDevice;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_PN;
        private System.Windows.Forms.TextBox textBox_VN;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.TextBox textBox_VID;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private UsbLibrary.UsbHidPort usbHidPort;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_LED;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_OFF2;
        private System.Windows.Forms.Button button_ON2;
        private System.Windows.Forms.Label label12;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_LED2;
    }
}

