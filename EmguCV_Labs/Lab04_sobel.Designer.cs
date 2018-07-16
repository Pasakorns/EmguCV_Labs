namespace EmguCV_Labs
{
    partial class Lab04_sobel
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
            this.trbApertureSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAperture = new System.Windows.Forms.Label();
            this.lblXorder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbXorder = new System.Windows.Forms.TrackBar();
            this.lblYorder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbYorder = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbApertureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbXorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYorder)).BeginInit();
            this.SuspendLayout();
            // 
            // trbApertureSize
            // 
            this.trbApertureSize.Location = new System.Drawing.Point(64, 122);
            this.trbApertureSize.Maximum = 3;
            this.trbApertureSize.Name = "trbApertureSize";
            this.trbApertureSize.Size = new System.Drawing.Size(252, 45);
            this.trbApertureSize.TabIndex = 0;
            this.trbApertureSize.Value = 2;
            this.trbApertureSize.Scroll += new System.EventHandler(this.trbApertureSize_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aperture Size :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAperture
            // 
            this.lblAperture.BackColor = System.Drawing.Color.White;
            this.lblAperture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAperture.Location = new System.Drawing.Point(328, 126);
            this.lblAperture.Name = "lblAperture";
            this.lblAperture.Size = new System.Drawing.Size(30, 20);
            this.lblAperture.TabIndex = 2;
            this.lblAperture.Text = "5";
            this.lblAperture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXorder
            // 
            this.lblXorder.BackColor = System.Drawing.Color.White;
            this.lblXorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXorder.Location = new System.Drawing.Point(328, 16);
            this.lblXorder.Name = "lblXorder";
            this.lblXorder.Size = new System.Drawing.Size(30, 20);
            this.lblXorder.TabIndex = 5;
            this.lblXorder.Text = "1";
            this.lblXorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "X Order :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbXorder
            // 
            this.trbXorder.Location = new System.Drawing.Point(64, 12);
            this.trbXorder.Maximum = 6;
            this.trbXorder.Minimum = 1;
            this.trbXorder.Name = "trbXorder";
            this.trbXorder.Size = new System.Drawing.Size(252, 45);
            this.trbXorder.TabIndex = 3;
            this.trbXorder.Value = 1;
            this.trbXorder.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblYorder
            // 
            this.lblYorder.BackColor = System.Drawing.Color.White;
            this.lblYorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYorder.Location = new System.Drawing.Point(328, 69);
            this.lblYorder.Name = "lblYorder";
            this.lblYorder.Size = new System.Drawing.Size(30, 20);
            this.lblYorder.TabIndex = 8;
            this.lblYorder.Text = "1";
            this.lblYorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y Order :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbYorder
            // 
            this.trbYorder.Location = new System.Drawing.Point(64, 65);
            this.trbYorder.Maximum = 6;
            this.trbYorder.Minimum = 1;
            this.trbYorder.Name = "trbYorder";
            this.trbYorder.Size = new System.Drawing.Size(252, 45);
            this.trbYorder.TabIndex = 6;
            this.trbYorder.Value = 1;
            this.trbYorder.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lab04_sobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trbYorder);
            this.Controls.Add(this.lblXorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbXorder);
            this.Controls.Add(this.lblAperture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbApertureSize);
            this.Name = "Lab04_sobel";
            this.Text = "Sobel Edge Detection";
            this.Load += new System.EventHandler(this.Lab04_sobel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbApertureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbXorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbApertureSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAperture;
        private System.Windows.Forms.Label lblXorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbXorder;
        private System.Windows.Forms.Label lblYorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbYorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}