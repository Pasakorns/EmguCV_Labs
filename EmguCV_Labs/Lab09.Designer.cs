namespace EmguCV_Labs
{
    partial class Lab09
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
            this.imbInput = new Emgu.CV.UI.ImageBox();
            this.imbOutput = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.cboThresType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbDilate = new System.Windows.Forms.TrackBar();
            this.trbErode = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCtY = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCtX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFoundNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBlobId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imbInput
            // 
            this.imbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbInput.Location = new System.Drawing.Point(12, 33);
            this.imbInput.Name = "imbInput";
            this.imbInput.Size = new System.Drawing.Size(320, 240);
            this.imbInput.TabIndex = 2;
            this.imbInput.TabStop = false;
            // 
            // imbOutput
            // 
            this.imbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbOutput.Location = new System.Drawing.Point(348, 33);
            this.imbOutput.Name = "imbOutput";
            this.imbOutput.Size = new System.Drawing.Size(320, 240);
            this.imbOutput.TabIndex = 3;
            this.imbOutput.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.openVideoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openVideoToolStripMenuItem.Text = "Open Image";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(40, 82);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trbDilate);
            this.groupBox1.Controls.Add(this.trbErode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trbThreshold);
            this.groupBox1.Controls.Add(this.cboThresType);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 7;
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
            this.trbThreshold.Value = 122;
            this.trbThreshold.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApply);
            this.groupBox2.Location = new System.Drawing.Point(348, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 186);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blob setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCtY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblCtX);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblArea);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblFoundNo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboBlobId);
            this.groupBox3.Location = new System.Drawing.Point(508, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 186);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // lblCtY
            // 
            this.lblCtY.AutoSize = true;
            this.lblCtY.Location = new System.Drawing.Point(80, 139);
            this.lblCtY.Name = "lblCtY";
            this.lblCtY.Size = new System.Drawing.Size(16, 13);
            this.lblCtY.TabIndex = 20;
            this.lblCtY.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "CT-Y :";
            // 
            // lblCtX
            // 
            this.lblCtX.AutoSize = true;
            this.lblCtX.Location = new System.Drawing.Point(80, 114);
            this.lblCtX.Name = "lblCtX";
            this.lblCtX.Size = new System.Drawing.Size(16, 13);
            this.lblCtX.TabIndex = 18;
            this.lblCtX.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CT-X :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(80, 90);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(16, 13);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Area :";
            // 
            // lblFoundNo
            // 
            this.lblFoundNo.AutoSize = true;
            this.lblFoundNo.Location = new System.Drawing.Point(80, 31);
            this.lblFoundNo.Name = "lblFoundNo";
            this.lblFoundNo.Size = new System.Drawing.Size(16, 13);
            this.lblFoundNo.TabIndex = 14;
            this.lblFoundNo.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Found :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID :";
            // 
            // cboBlobId
            // 
            this.cboBlobId.FormattingEnabled = true;
            this.cboBlobId.Location = new System.Drawing.Point(83, 55);
            this.cboBlobId.Name = "cboBlobId";
            this.cboBlobId.Size = new System.Drawing.Size(58, 21);
            this.cboBlobId.TabIndex = 7;
            this.cboBlobId.SelectedIndexChanged += new System.EventHandler(this.cboBlobId_SelectedIndexChanged);
            // 
            // Lab09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imbOutput);
            this.Controls.Add(this.imbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab09";
            this.Text = "Lab09 : Blob";
            this.Load += new System.EventHandler(this.Lab09_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imbInput;
        private Emgu.CV.UI.ImageBox imbOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cboThresType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbDilate;
        private System.Windows.Forms.TrackBar trbErode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbThreshold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCtY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCtX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFoundNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBlobId;
    }
}