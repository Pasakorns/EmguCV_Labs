﻿namespace EmguCV_Labs
{
    partial class Lab03
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
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.htgRed = new Emgu.CV.UI.HistogramBox();
            this.htgGreen = new Emgu.CV.UI.HistogramBox();
            this.htgBlue = new Emgu.CV.UI.HistogramBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.panAndZoomPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(24, 50);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(400, 300);
            this.panAndZoomPictureBox1.TabIndex = 0;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Img";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // htgRed
            // 
            this.htgRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgRed.Location = new System.Drawing.Point(430, 10);
            this.htgRed.Name = "htgRed";
            this.htgRed.Size = new System.Drawing.Size(358, 110);
            this.htgRed.TabIndex = 2;
            // 
            // htgGreen
            // 
            this.htgGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgGreen.Location = new System.Drawing.Point(430, 124);
            this.htgGreen.Name = "htgGreen";
            this.htgGreen.Size = new System.Drawing.Size(358, 110);
            this.htgGreen.TabIndex = 3;
            // 
            // htgBlue
            // 
            this.htgBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgBlue.Location = new System.Drawing.Point(430, 240);
            this.htgBlue.Name = "htgBlue";
            this.htgBlue.Size = new System.Drawing.Size(358, 110);
            this.htgBlue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BLUE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update Histrogram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lab03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htgBlue);
            this.Controls.Add(this.htgGreen);
            this.Controls.Add(this.htgRed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Lab03";
            this.Text = "Lab 03 : Histrogram";
            this.Load += new System.EventHandler(this.Lab03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.HistogramBox htgRed;
        private Emgu.CV.UI.HistogramBox htgGreen;
        private Emgu.CV.UI.HistogramBox htgBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}