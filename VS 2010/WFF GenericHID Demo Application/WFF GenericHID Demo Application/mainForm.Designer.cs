namespace WFF_GenericHID_Demo_Application
    {
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usbDeviceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.potStateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2StateLabel = new System.Windows.Forms.Label();
            this.button1StateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.debugCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.deviceStatusPollTimer = new System.Windows.Forms.Timer(this.components);
            this.button2PictureBox = new System.Windows.Forms.PictureBox();
            this.button1PictureBox = new System.Windows.Forms.PictureBox();
            this.led4PictureBox = new System.Windows.Forms.PictureBox();
            this.led3PictureBox = new System.Windows.Forms.PictureBox();
            this.led2PictureBox = new System.Windows.Forms.PictureBox();
            this.led1PictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.potentiometerAnalogMeter = new Instruments.AnalogMeter();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usbDeviceStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(432, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // usbDeviceStatusLabel
            // 
            this.usbDeviceStatusLabel.Name = "usbDeviceStatusLabel";
            this.usbDeviceStatusLabel.Size = new System.Drawing.Size(117, 17);
            this.usbDeviceStatusLabel.Text = "USB device detached";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.potentiometerAnalogMeter);
            this.groupBox1.Controls.Add(this.button2PictureBox);
            this.groupBox1.Controls.Add(this.button1PictureBox);
            this.groupBox1.Controls.Add(this.potStateLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2StateLabel);
            this.groupBox1.Controls.Add(this.button1StateLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.led4PictureBox);
            this.groupBox1.Controls.Add(this.led3PictureBox);
            this.groupBox1.Controls.Add(this.led2PictureBox);
            this.groupBox1.Controls.Add(this.led1PictureBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USB Device Status";
            // 
            // potStateLabel
            // 
            this.potStateLabel.AutoSize = true;
            this.potStateLabel.Location = new System.Drawing.Point(85, 70);
            this.potStateLabel.Name = "potStateLabel";
            this.potStateLabel.Size = new System.Drawing.Size(13, 13);
            this.potStateLabel.TabIndex = 10;
            this.potStateLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Potentiometer:";
            // 
            // button2StateLabel
            // 
            this.button2StateLabel.AutoSize = true;
            this.button2StateLabel.Location = new System.Drawing.Point(173, 47);
            this.button2StateLabel.Name = "button2StateLabel";
            this.button2StateLabel.Size = new System.Drawing.Size(21, 13);
            this.button2StateLabel.TabIndex = 8;
            this.button2StateLabel.Text = "Off";
            // 
            // button1StateLabel
            // 
            this.button1StateLabel.AutoSize = true;
            this.button1StateLabel.Location = new System.Drawing.Point(110, 47);
            this.button1StateLabel.Name = "button1StateLabel";
            this.button1StateLabel.Size = new System.Drawing.Size(21, 13);
            this.button1StateLabel.TabIndex = 7;
            this.button1StateLabel.Text = "Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buttons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Click to toggle)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "LEDs:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.debugTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USB Device Debug Output";
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(7, 20);
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.Size = new System.Drawing.Size(394, 172);
            this.debugTextBox.TabIndex = 0;
            // 
            // debugCollectionTimer
            // 
            this.debugCollectionTimer.Enabled = true;
            this.debugCollectionTimer.Interval = 250;
            this.debugCollectionTimer.Tick += new System.EventHandler(this.debugCollectionTimer_Tick);
            // 
            // deviceStatusPollTimer
            // 
            this.deviceStatusPollTimer.Enabled = true;
            this.deviceStatusPollTimer.Tick += new System.EventHandler(this.deviceStatusPollTimer_Tick);
            // 
            // button2PictureBox
            // 
            this.button2PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.blue_off_16;
            this.button2PictureBox.InitialImage = null;
            this.button2PictureBox.Location = new System.Drawing.Point(151, 44);
            this.button2PictureBox.Name = "button2PictureBox";
            this.button2PictureBox.Size = new System.Drawing.Size(16, 16);
            this.button2PictureBox.TabIndex = 12;
            this.button2PictureBox.TabStop = false;
            // 
            // button1PictureBox
            // 
            this.button1PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.blue_off_16;
            this.button1PictureBox.InitialImage = null;
            this.button1PictureBox.Location = new System.Drawing.Point(88, 44);
            this.button1PictureBox.Name = "button1PictureBox";
            this.button1PictureBox.Size = new System.Drawing.Size(16, 16);
            this.button1PictureBox.TabIndex = 11;
            this.button1PictureBox.TabStop = false;
            // 
            // led4PictureBox
            // 
            this.led4PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.red_off_16;
            this.led4PictureBox.Location = new System.Drawing.Point(182, 22);
            this.led4PictureBox.Name = "led4PictureBox";
            this.led4PictureBox.Size = new System.Drawing.Size(16, 16);
            this.led4PictureBox.TabIndex = 3;
            this.led4PictureBox.TabStop = false;
            this.led4PictureBox.Click += new System.EventHandler(this.led4PictureBox_Click);
            // 
            // led3PictureBox
            // 
            this.led3PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.red_off_16;
            this.led3PictureBox.Location = new System.Drawing.Point(151, 22);
            this.led3PictureBox.Name = "led3PictureBox";
            this.led3PictureBox.Size = new System.Drawing.Size(16, 16);
            this.led3PictureBox.TabIndex = 2;
            this.led3PictureBox.TabStop = false;
            this.led3PictureBox.Click += new System.EventHandler(this.led3PictureBox_Click);
            // 
            // led2PictureBox
            // 
            this.led2PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.red_off_16;
            this.led2PictureBox.Location = new System.Drawing.Point(119, 22);
            this.led2PictureBox.Name = "led2PictureBox";
            this.led2PictureBox.Size = new System.Drawing.Size(16, 16);
            this.led2PictureBox.TabIndex = 1;
            this.led2PictureBox.TabStop = false;
            this.led2PictureBox.Click += new System.EventHandler(this.led2PictureBox_Click);
            // 
            // led1PictureBox
            // 
            this.led1PictureBox.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.red_off_16;
            this.led1PictureBox.InitialImage = null;
            this.led1PictureBox.Location = new System.Drawing.Point(88, 22);
            this.led1PictureBox.Name = "led1PictureBox";
            this.led1PictureBox.Size = new System.Drawing.Size(16, 16);
            this.led1PictureBox.TabIndex = 0;
            this.led1PictureBox.TabStop = false;
            this.led1PictureBox.Click += new System.EventHandler(this.led1PictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFF_GenericHID_Demo_Application.Properties.Resources.wff_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // potentiometerAnalogMeter
            // 
            this.potentiometerAnalogMeter.FrameColor = System.Drawing.Color.Black;
            this.potentiometerAnalogMeter.FramePadding = new System.Windows.Forms.Padding(5);
            this.potentiometerAnalogMeter.InternalPadding = new System.Windows.Forms.Padding(5);
            this.potentiometerAnalogMeter.Location = new System.Drawing.Point(60, 99);
            this.potentiometerAnalogMeter.MaxValue = 1024F;
            this.potentiometerAnalogMeter.MinValue = 0F;
            this.potentiometerAnalogMeter.Name = "potentiometerAnalogMeter";
            this.potentiometerAnalogMeter.Size = new System.Drawing.Size(283, 193);
            this.potentiometerAnalogMeter.TabIndex = 13;
            this.potentiometerAnalogMeter.Text = "Potentiometer";
            this.potentiometerAnalogMeter.TickLargeFrequency = 100F;
            this.potentiometerAnalogMeter.TickSmallFrequency = 20F;
            this.potentiometerAnalogMeter.TickStartAngle = 20F;
            this.potentiometerAnalogMeter.Value = 0F;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "WFF GenericHID Demo Application";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel usbDeviceStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox led4PictureBox;
        private System.Windows.Forms.PictureBox led3PictureBox;
        private System.Windows.Forms.PictureBox led2PictureBox;
        private System.Windows.Forms.PictureBox led1PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label potStateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label button2StateLabel;
        private System.Windows.Forms.Label button1StateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.Timer debugCollectionTimer;
        private System.Windows.Forms.Timer deviceStatusPollTimer;
        private System.Windows.Forms.PictureBox button2PictureBox;
        private System.Windows.Forms.PictureBox button1PictureBox;
        private Instruments.AnalogMeter potentiometerAnalogMeter;
        }
    }

