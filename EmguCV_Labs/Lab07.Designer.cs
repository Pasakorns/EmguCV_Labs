namespace EmguCV_Labs
{
    partial class Lab07
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
            this.imbOrigin = new Emgu.CV.UI.ImageBox();
            this.imbContour = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboApprox = new System.Windows.Forms.ComboBox();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.cboRetry = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboContoursId = new System.Windows.Forms.ComboBox();
            this.lblFoundNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblXpos = new System.Windows.Forms.Label();
            this.lblYpos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imbOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbContour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imbOrigin
            // 
            this.imbOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbOrigin.Location = new System.Drawing.Point(12, 47);
            this.imbOrigin.Name = "imbOrigin";
            this.imbOrigin.Size = new System.Drawing.Size(247, 162);
            this.imbOrigin.TabIndex = 2;
            this.imbOrigin.TabStop = false;
            // 
            // imbContour
            // 
            this.imbContour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbContour.Location = new System.Drawing.Point(12, 215);
            this.imbContour.Name = "imbContour";
            this.imbContour.Size = new System.Drawing.Size(430, 320);
            this.imbContour.TabIndex = 3;
            this.imbContour.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboApprox);
            this.groupBox1.Controls.Add(this.nudThreshold);
            this.groupBox1.Controls.Add(this.cboRetry);
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contours setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Threshold :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Approximate method :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Retry mode :";
            // 
            // cboApprox
            // 
            this.cboApprox.FormattingEnabled = true;
            this.cboApprox.Location = new System.Drawing.Point(87, 73);
            this.cboApprox.Name = "cboApprox";
            this.cboApprox.Size = new System.Drawing.Size(121, 21);
            this.cboApprox.TabIndex = 9;
            // 
            // nudThreshold
            // 
            this.nudThreshold.Location = new System.Drawing.Point(85, 120);
            this.nudThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(75, 20);
            this.nudThreshold.TabIndex = 8;
            this.nudThreshold.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // cboRetry
            // 
            this.cboRetry.FormattingEnabled = true;
            this.cboRetry.Location = new System.Drawing.Point(87, 35);
            this.cboRetry.Name = "cboRetry";
            this.cboRetry.Size = new System.Drawing.Size(121, 21);
            this.cboRetry.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYpos);
            this.groupBox2.Controls.Add(this.lblXpos);
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboContoursId);
            this.groupBox2.Controls.Add(this.lblFoundNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(455, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contour ID :";
            // 
            // cboContoursId
            // 
            this.cboContoursId.FormattingEnabled = true;
            this.cboContoursId.Items.AddRange(new object[] {
            "-1"});
            this.cboContoursId.Location = new System.Drawing.Point(87, 75);
            this.cboContoursId.Name = "cboContoursId";
            this.cboContoursId.Size = new System.Drawing.Size(55, 21);
            this.cboContoursId.TabIndex = 2;
            this.cboContoursId.SelectedIndexChanged += new System.EventHandler(this.cboContoursId_SelectedIndexChanged);
            // 
            // lblFoundNo
            // 
            this.lblFoundNo.AutoSize = true;
            this.lblFoundNo.Location = new System.Drawing.Point(90, 39);
            this.lblFoundNo.Name = "lblFoundNo";
            this.lblFoundNo.Size = new System.Drawing.Size(16, 13);
            this.lblFoundNo.TabIndex = 1;
            this.lblFoundNo.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Found :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Area :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Xpos :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ypos :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(90, 131);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(16, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "---";
            // 
            // lblXpos
            // 
            this.lblXpos.AutoSize = true;
            this.lblXpos.Location = new System.Drawing.Point(90, 155);
            this.lblXpos.Name = "lblXpos";
            this.lblXpos.Size = new System.Drawing.Size(16, 13);
            this.lblXpos.TabIndex = 9;
            this.lblXpos.Text = "---";
            // 
            // lblYpos
            // 
            this.lblYpos.AutoSize = true;
            this.lblYpos.Location = new System.Drawing.Point(90, 179);
            this.lblYpos.Name = "lblYpos";
            this.lblYpos.Size = new System.Drawing.Size(16, 13);
            this.lblYpos.TabIndex = 10;
            this.lblYpos.Text = "---";
            // 
            // Lab07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imbContour);
            this.Controls.Add(this.imbOrigin);
            this.Name = "Lab07";
            this.Text = "Contours";
            this.Load += new System.EventHandler(this.Lab07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imbOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbContour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imbOrigin;
        private Emgu.CV.UI.ImageBox imbContour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboApprox;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.ComboBox cboRetry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFoundNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboContoursId;
        private System.Windows.Forms.Label lblYpos;
        private System.Windows.Forms.Label lblXpos;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}