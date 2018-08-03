namespace EmguCV_Labs
{
    partial class Lab11
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
            this.imbSoucre = new Emgu.CV.UI.ImageBox();
            this.imbResult = new Emgu.CV.UI.ImageBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYCursor = new System.Windows.Forms.Label();
            this.lblXCursor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudP0X = new System.Windows.Forms.NumericUpDown();
            this.nudP0Y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudP3Y = new System.Windows.Forms.NumericUpDown();
            this.nudP3X = new System.Windows.Forms.NumericUpDown();
            this.nudP2Y = new System.Windows.Forms.NumericUpDown();
            this.nudP2X = new System.Windows.Forms.NumericUpDown();
            this.nudP1Y = new System.Windows.Forms.NumericUpDown();
            this.nudP1X = new System.Windows.Forms.NumericUpDown();
            this.btnTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imbSoucre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP0X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP0Y)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1X)).BeginInit();
            this.SuspendLayout();
            // 
            // imbSoucre
            // 
            this.imbSoucre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbSoucre.Location = new System.Drawing.Point(12, 12);
            this.imbSoucre.Name = "imbSoucre";
            this.imbSoucre.Size = new System.Drawing.Size(320, 240);
            this.imbSoucre.TabIndex = 2;
            this.imbSoucre.TabStop = false;
            this.imbSoucre.MouseLeave += new System.EventHandler(this.imbSoucre_MouseLeave);
            this.imbSoucre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imbSoucre_MouseMove);
            // 
            // imbResult
            // 
            this.imbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbResult.Location = new System.Drawing.Point(341, 12);
            this.imbResult.Name = "imbResult";
            this.imbResult.Size = new System.Drawing.Size(320, 240);
            this.imbResult.TabIndex = 3;
            this.imbResult.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(12, 258);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "open image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYCursor);
            this.groupBox1.Controls.Add(this.lblXCursor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursor Position";
            // 
            // lblYCursor
            // 
            this.lblYCursor.AutoSize = true;
            this.lblYCursor.Location = new System.Drawing.Point(32, 58);
            this.lblYCursor.Name = "lblYCursor";
            this.lblYCursor.Size = new System.Drawing.Size(16, 13);
            this.lblYCursor.TabIndex = 3;
            this.lblYCursor.Text = "---";
            // 
            // lblXCursor
            // 
            this.lblXCursor.AutoSize = true;
            this.lblXCursor.Location = new System.Drawing.Point(32, 28);
            this.lblXCursor.Name = "lblXCursor";
            this.lblXCursor.Size = new System.Drawing.Size(16, 13);
            this.lblXCursor.TabIndex = 2;
            this.lblXCursor.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "p0 :";
            // 
            // nudP0X
            // 
            this.nudP0X.Location = new System.Drawing.Point(47, 41);
            this.nudP0X.Maximum = new decimal(new int[] {
            319,
            0,
            0,
            0});
            this.nudP0X.Name = "nudP0X";
            this.nudP0X.Size = new System.Drawing.Size(56, 20);
            this.nudP0X.TabIndex = 1;
            this.nudP0X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudP0X.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP0Y
            // 
            this.nudP0Y.Location = new System.Drawing.Point(120, 41);
            this.nudP0Y.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.nudP0Y.Name = "nudP0Y";
            this.nudP0Y.Size = new System.Drawing.Size(56, 20);
            this.nudP0Y.TabIndex = 2;
            this.nudP0Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudP0Y.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "p1 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "p2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "p3 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudP3Y);
            this.groupBox2.Controls.Add(this.nudP3X);
            this.groupBox2.Controls.Add(this.nudP2Y);
            this.groupBox2.Controls.Add(this.nudP2X);
            this.groupBox2.Controls.Add(this.nudP1Y);
            this.groupBox2.Controls.Add(this.nudP1X);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudP0Y);
            this.groupBox2.Controls.Add(this.nudP0X);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(118, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 157);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Corner Specify";
            // 
            // nudP3Y
            // 
            this.nudP3Y.Location = new System.Drawing.Point(120, 119);
            this.nudP3Y.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.nudP3Y.Name = "nudP3Y";
            this.nudP3Y.Size = new System.Drawing.Size(56, 20);
            this.nudP3Y.TabIndex = 17;
            this.nudP3Y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudP3Y.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP3X
            // 
            this.nudP3X.Location = new System.Drawing.Point(47, 119);
            this.nudP3X.Maximum = new decimal(new int[] {
            319,
            0,
            0,
            0});
            this.nudP3X.Name = "nudP3X";
            this.nudP3X.Size = new System.Drawing.Size(56, 20);
            this.nudP3X.TabIndex = 16;
            this.nudP3X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudP3X.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP2Y
            // 
            this.nudP2Y.Location = new System.Drawing.Point(120, 93);
            this.nudP2Y.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.nudP2Y.Name = "nudP2Y";
            this.nudP2Y.Size = new System.Drawing.Size(56, 20);
            this.nudP2Y.TabIndex = 15;
            this.nudP2Y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudP2Y.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP2X
            // 
            this.nudP2X.Location = new System.Drawing.Point(47, 93);
            this.nudP2X.Maximum = new decimal(new int[] {
            319,
            0,
            0,
            0});
            this.nudP2X.Name = "nudP2X";
            this.nudP2X.Size = new System.Drawing.Size(56, 20);
            this.nudP2X.TabIndex = 14;
            this.nudP2X.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudP2X.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP1Y
            // 
            this.nudP1Y.Location = new System.Drawing.Point(120, 67);
            this.nudP1Y.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.nudP1Y.Name = "nudP1Y";
            this.nudP1Y.Size = new System.Drawing.Size(56, 20);
            this.nudP1Y.TabIndex = 13;
            this.nudP1Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudP1Y.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // nudP1X
            // 
            this.nudP1X.Location = new System.Drawing.Point(47, 67);
            this.nudP1X.Maximum = new decimal(new int[] {
            319,
            0,
            0,
            0});
            this.nudP1X.Name = "nudP1X";
            this.nudP1X.Size = new System.Drawing.Size(56, 20);
            this.nudP1X.TabIndex = 12;
            this.nudP1X.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudP1X.ValueChanged += new System.EventHandler(this.nudPXY_ValueChanged);
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(465, 273);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 7;
            this.btnTrans.Text = "Transform";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // Lab11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 440);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.imbResult);
            this.Controls.Add(this.imbSoucre);
            this.Name = "Lab11";
            this.Text = "Lab 11 : Perspective transform";
            this.Load += new System.EventHandler(this.Lab11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imbSoucre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP0X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP0Y)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1X)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imbSoucre;
        private Emgu.CV.UI.ImageBox imbResult;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYCursor;
        private System.Windows.Forms.Label lblXCursor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudP0X;
        private System.Windows.Forms.NumericUpDown nudP0Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudP1Y;
        private System.Windows.Forms.NumericUpDown nudP1X;
        private System.Windows.Forms.NumericUpDown nudP2Y;
        private System.Windows.Forms.NumericUpDown nudP2X;
        private System.Windows.Forms.NumericUpDown nudP3Y;
        private System.Windows.Forms.NumericUpDown nudP3X;
        private System.Windows.Forms.Button btnTrans;
    }
}