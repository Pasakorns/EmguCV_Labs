namespace EmguCV_Labs
{
    partial class Lab04_laplaciant
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
            this.nudApertureSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudApertureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // nudApertureSize
            // 
            this.nudApertureSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudApertureSize.Location = new System.Drawing.Point(132, 25);
            this.nudApertureSize.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudApertureSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudApertureSize.Name = "nudApertureSize";
            this.nudApertureSize.ReadOnly = true;
            this.nudApertureSize.Size = new System.Drawing.Size(62, 20);
            this.nudApertureSize.TabIndex = 0;
            this.nudApertureSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aperture size :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lab04_laplaciant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudApertureSize);
            this.Name = "Lab04_laplaciant";
            this.Text = "Laplaciant Edge Detection";
            this.Load += new System.EventHandler(this.Lab04_laplaciant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudApertureSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudApertureSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}