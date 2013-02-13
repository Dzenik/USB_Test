namespace WFF_GenericHID_Test_Application
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test5ResultLabel = new System.Windows.Forms.Label();
            this.test4ResultLabel = new System.Windows.Forms.Label();
            this.test3ResultLabel = new System.Windows.Forms.Label();
            this.test2ResultLabel = new System.Windows.Forms.Label();
            this.test1ResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.test5Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test4Button = new System.Windows.Forms.Button();
            this.test3Button = new System.Windows.Forms.Button();
            this.test2Button = new System.Windows.Forms.Button();
            this.test1Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.collectDebugCheckBox = new System.Windows.Forms.CheckBox();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usbDeviceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wffWebLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.debugCollectionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.test5ResultLabel);
            this.groupBox1.Controls.Add(this.test4ResultLabel);
            this.groupBox1.Controls.Add(this.test3ResultLabel);
            this.groupBox1.Controls.Add(this.test2ResultLabel);
            this.groupBox1.Controls.Add(this.test1ResultLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.test5Button);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.test4Button);
            this.groupBox1.Controls.Add(this.test3Button);
            this.groupBox1.Controls.Add(this.test2Button);
            this.groupBox1.Controls.Add(this.test1Button);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generic HID Communication Tests";
            // 
            // test5ResultLabel
            // 
            this.test5ResultLabel.AutoSize = true;
            this.test5ResultLabel.Location = new System.Drawing.Point(297, 145);
            this.test5ResultLabel.Name = "test5ResultLabel";
            this.test5ResultLabel.Size = new System.Drawing.Size(96, 13);
            this.test5ResultLabel.TabIndex = 14;
            this.test5ResultLabel.Text = "Test not performed";
            // 
            // test4ResultLabel
            // 
            this.test4ResultLabel.AutoSize = true;
            this.test4ResultLabel.Location = new System.Drawing.Point(297, 115);
            this.test4ResultLabel.Name = "test4ResultLabel";
            this.test4ResultLabel.Size = new System.Drawing.Size(96, 13);
            this.test4ResultLabel.TabIndex = 13;
            this.test4ResultLabel.Text = "Test not performed";
            // 
            // test3ResultLabel
            // 
            this.test3ResultLabel.AutoSize = true;
            this.test3ResultLabel.Location = new System.Drawing.Point(297, 85);
            this.test3ResultLabel.Name = "test3ResultLabel";
            this.test3ResultLabel.Size = new System.Drawing.Size(96, 13);
            this.test3ResultLabel.TabIndex = 12;
            this.test3ResultLabel.Text = "Test not performed";
            // 
            // test2ResultLabel
            // 
            this.test2ResultLabel.AutoSize = true;
            this.test2ResultLabel.Location = new System.Drawing.Point(297, 55);
            this.test2ResultLabel.Name = "test2ResultLabel";
            this.test2ResultLabel.Size = new System.Drawing.Size(96, 13);
            this.test2ResultLabel.TabIndex = 11;
            this.test2ResultLabel.Text = "Test not performed";
            // 
            // test1ResultLabel
            // 
            this.test1ResultLabel.AutoSize = true;
            this.test1ResultLabel.Location = new System.Drawing.Point(297, 25);
            this.test1ResultLabel.Name = "test1ResultLabel";
            this.test1ResultLabel.Size = new System.Drawing.Size(96, 13);
            this.test1ResultLabel.TabIndex = 10;
            this.test1ResultLabel.Text = "Test not performed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Send 128 packets, receive 128 packets";
            // 
            // test5Button
            // 
            this.test5Button.Enabled = false;
            this.test5Button.Location = new System.Drawing.Point(7, 140);
            this.test5Button.Name = "test5Button";
            this.test5Button.Size = new System.Drawing.Size(75, 23);
            this.test5Button.TabIndex = 8;
            this.test5Button.Text = "Test 5";
            this.test5Button.UseVisualStyleBackColor = true;
            this.test5Button.Click += new System.EventHandler(this.test5Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Send 128 packets, receive 1 packet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send 1 packet, receive 128 packets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send 1 packet, receive 1 packet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Send 1 packet";
            // 
            // test4Button
            // 
            this.test4Button.Enabled = false;
            this.test4Button.Location = new System.Drawing.Point(7, 110);
            this.test4Button.Name = "test4Button";
            this.test4Button.Size = new System.Drawing.Size(75, 23);
            this.test4Button.TabIndex = 3;
            this.test4Button.Text = "Test 4";
            this.test4Button.UseVisualStyleBackColor = true;
            this.test4Button.Click += new System.EventHandler(this.test4Button_Click);
            // 
            // test3Button
            // 
            this.test3Button.Enabled = false;
            this.test3Button.Location = new System.Drawing.Point(7, 80);
            this.test3Button.Name = "test3Button";
            this.test3Button.Size = new System.Drawing.Size(75, 23);
            this.test3Button.TabIndex = 2;
            this.test3Button.Text = "Test 3";
            this.test3Button.UseVisualStyleBackColor = true;
            this.test3Button.Click += new System.EventHandler(this.test3Button_Click);
            // 
            // test2Button
            // 
            this.test2Button.Enabled = false;
            this.test2Button.Location = new System.Drawing.Point(7, 50);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(75, 23);
            this.test2Button.TabIndex = 1;
            this.test2Button.Text = "Test 2";
            this.test2Button.UseVisualStyleBackColor = true;
            this.test2Button.Click += new System.EventHandler(this.test2Button_Click);
            // 
            // test1Button
            // 
            this.test1Button.Enabled = false;
            this.test1Button.Location = new System.Drawing.Point(7, 20);
            this.test1Button.Name = "test1Button";
            this.test1Button.Size = new System.Drawing.Size(75, 23);
            this.test1Button.TabIndex = 0;
            this.test1Button.Text = "Test 1";
            this.test1Button.UseVisualStyleBackColor = true;
            this.test1Button.Click += new System.EventHandler(this.test1Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.collectDebugCheckBox);
            this.groupBox2.Controls.Add(this.debugTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 248);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USB Device Debug Output";
            // 
            // collectDebugCheckBox
            // 
            this.collectDebugCheckBox.AutoSize = true;
            this.collectDebugCheckBox.Checked = true;
            this.collectDebugCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.collectDebugCheckBox.Location = new System.Drawing.Point(7, 20);
            this.collectDebugCheckBox.Name = "collectDebugCheckBox";
            this.collectDebugCheckBox.Size = new System.Drawing.Size(159, 17);
            this.collectDebugCheckBox.TabIndex = 1;
            this.collectDebugCheckBox.Text = "Collect device debug output";
            this.collectDebugCheckBox.UseVisualStyleBackColor = true;
            this.collectDebugCheckBox.CheckedChanged += new System.EventHandler(this.collectDebugCheckBox_CheckedChanged);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(6, 43);
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.Size = new System.Drawing.Size(409, 197);
            this.debugTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usbDeviceStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(449, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // usbDeviceStatusLabel
            // 
            this.usbDeviceStatusLabel.Name = "usbDeviceStatusLabel";
            this.usbDeviceStatusLabel.Size = new System.Drawing.Size(129, 17);
            this.usbDeviceStatusLabel.Text = "USB Device is detached";
            // 
            // wffWebLinkLabel
            // 
            this.wffWebLinkLabel.AutoSize = true;
            this.wffWebLinkLabel.Location = new System.Drawing.Point(10, 512);
            this.wffWebLinkLabel.Name = "wffWebLinkLabel";
            this.wffWebLinkLabel.Size = new System.Drawing.Size(158, 13);
            this.wffWebLinkLabel.TabIndex = 4;
            this.wffWebLinkLabel.TabStop = true;
            this.wffWebLinkLabel.Text = "http://www.waitingforfriday.com";
            this.wffWebLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wffWebLinkLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "WFF GenericHID Communication Library 4_0";
            // 
            // debugCollectionTimer
            // 
            this.debugCollectionTimer.Enabled = true;
            this.debugCollectionTimer.Tick += new System.EventHandler(this.debugCollectionTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 557);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wffWebLinkLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WFF GenericHID Test Application 4_0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label test5ResultLabel;
        private System.Windows.Forms.Label test4ResultLabel;
        private System.Windows.Forms.Label test3ResultLabel;
        private System.Windows.Forms.Label test2ResultLabel;
        private System.Windows.Forms.Label test1ResultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button test5Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button test4Button;
        private System.Windows.Forms.Button test3Button;
        private System.Windows.Forms.Button test2Button;
        private System.Windows.Forms.Button test1Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel usbDeviceStatusLabel;
        private System.Windows.Forms.LinkLabel wffWebLinkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer debugCollectionTimer;
        private System.Windows.Forms.CheckBox collectDebugCheckBox;
        }
    }