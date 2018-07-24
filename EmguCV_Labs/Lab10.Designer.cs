namespace EmguCV_Labs
{
    partial class Lab10
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxArea = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudMinArea = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbDilate = new System.Windows.Forms.TrackBar();
            this.trbErode = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            this.cboThresType = new System.Windows.Forms.ComboBox();
            this.imbOutput = new Emgu.CV.UI.ImageBox();
            this.imbInput = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudScale);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblDistance);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblSpeed);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(503, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 186);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "pixel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "mm/sec";
            // 
            // nudScale
            // 
            this.nudScale.DecimalPlaces = 2;
            this.nudScale.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.nudScale.Location = new System.Drawing.Point(57, 30);
            this.nudScale.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudScale.Name = "nudScale";
            this.nudScale.Size = new System.Drawing.Size(52, 20);
            this.nudScale.TabIndex = 26;
            this.nudScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudScale.ValueChanged += new System.EventHandler(this.nudScale_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(60, 134);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 13);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Time :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(60, 110);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(16, 13);
            this.lblDistance.TabIndex = 22;
            this.lblDistance.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Distance :";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(60, 88);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(16, 13);
            this.lblSpeed.TabIndex = 14;
            this.lblSpeed.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Speed :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaxArea);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudMinArea);
            this.groupBox2.Location = new System.Drawing.Point(343, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 186);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blob fillter";
            // 
            // nudMaxArea
            // 
            this.nudMaxArea.Location = new System.Drawing.Point(77, 67);
            this.nudMaxArea.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMaxArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxArea.Name = "nudMaxArea";
            this.nudMaxArea.Size = new System.Drawing.Size(61, 20);
            this.nudMaxArea.TabIndex = 31;
            this.nudMaxArea.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudMaxArea.ValueChanged += new System.EventHandler(this.nudMaxArea_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Max area:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Min area:";
            // 
            // nudMinArea
            // 
            this.nudMinArea.Location = new System.Drawing.Point(77, 34);
            this.nudMinArea.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudMinArea.Name = "nudMinArea";
            this.nudMinArea.Size = new System.Drawing.Size(61, 20);
            this.nudMinArea.TabIndex = 28;
            this.nudMinArea.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinArea.ValueChanged += new System.EventHandler(this.nudMaxArea_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trbDilate);
            this.groupBox1.Controls.Add(this.trbErode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trbThreshold);
            this.groupBox1.Controls.Add(this.cboThresType);
            this.groupBox1.Location = new System.Drawing.Point(7, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Processing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dilate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Erode :";
            // 
            // trbDilate
            // 
            this.trbDilate.Location = new System.Drawing.Point(69, 134);
            this.trbDilate.Name = "trbDilate";
            this.trbDilate.Size = new System.Drawing.Size(229, 45);
            this.trbDilate.TabIndex = 10;
            this.trbDilate.Value = 8;
            this.trbDilate.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // trbErode
            // 
            this.trbErode.Location = new System.Drawing.Point(69, 82);
            this.trbErode.Name = "trbErode";
            this.trbErode.Size = new System.Drawing.Size(229, 45);
            this.trbErode.TabIndex = 9;
            this.trbErode.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Threshold :";
            // 
            // trbThreshold
            // 
            this.trbThreshold.Location = new System.Drawing.Point(134, 28);
            this.trbThreshold.Maximum = 255;
            this.trbThreshold.Name = "trbThreshold";
            this.trbThreshold.Size = new System.Drawing.Size(180, 45);
            this.trbThreshold.TabIndex = 7;
            this.trbThreshold.TickFrequency = 64;
            this.trbThreshold.Value = 200;
            this.trbThreshold.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // cboThresType
            // 
            this.cboThresType.FormattingEnabled = true;
            this.cboThresType.Location = new System.Drawing.Point(64, 28);
            this.cboThresType.Name = "cboThresType";
            this.cboThresType.Size = new System.Drawing.Size(64, 21);
            this.cboThresType.TabIndex = 6;
            this.cboThresType.SelectedIndexChanged += new System.EventHandler(this.cboThresType_SelectedIndexChanged);
            // 
            // imbOutput
            // 
            this.imbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbOutput.Location = new System.Drawing.Point(343, 31);
            this.imbOutput.Name = "imbOutput";
            this.imbOutput.Size = new System.Drawing.Size(320, 240);
            this.imbOutput.TabIndex = 11;
            this.imbOutput.TabStop = false;
            // 
            // imbInput
            // 
            this.imbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbInput.Location = new System.Drawing.Point(7, 31);
            this.imbInput.Name = "imbInput";
            this.imbInput.Size = new System.Drawing.Size(320, 240);
            this.imbInput.TabIndex = 10;
            this.imbInput.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // openVideoToolStripMenuItem
            // 
            this.openVideoToolStripMenuItem.Name = "openVideoToolStripMenuItem";
            this.openVideoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openVideoToolStripMenuItem.Text = "open video";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.openVideoToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cal scale :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "mm/pixel";
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imbOutput);
            this.Controls.Add(this.imbInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Lab10";
            this.Text = "Lab 10 : Object Tracking";
            this.Load += new System.EventHandler(this.Lab10_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbDilate;
        private System.Windows.Forms.TrackBar trbErode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbThreshold;
        private System.Windows.Forms.ComboBox cboThresType;
        private Emgu.CV.UI.ImageBox imbOutput;
        private Emgu.CV.UI.ImageBox imbInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudMinArea;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
    }
}