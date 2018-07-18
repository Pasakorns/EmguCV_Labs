namespace EmguCV_Labs
{
    partial class Lab08
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
            this.imbColor = new Emgu.CV.UI.ImageBox();
            this.imbGray = new Emgu.CV.UI.ImageBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbHiV = new System.Windows.Forms.TrackBar();
            this.trbHiS = new System.Windows.Forms.TrackBar();
            this.trbHiH = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trbLowV = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trbLowS = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trbLowH = new System.Windows.Forms.TrackBar();
            this.trbParam1 = new System.Windows.Forms.TrackBar();
            this.trbParam2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbGray)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbParam2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imbColor
            // 
            this.imbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbColor.Location = new System.Drawing.Point(12, 38);
            this.imbColor.Name = "imbColor";
            this.imbColor.Size = new System.Drawing.Size(320, 240);
            this.imbColor.TabIndex = 2;
            this.imbColor.TabStop = false;
            // 
            // imbGray
            // 
            this.imbGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbGray.Location = new System.Drawing.Point(338, 38);
            this.imbGray.Name = "imbGray";
            this.imbGray.Size = new System.Drawing.Size(320, 240);
            this.imbGray.TabIndex = 3;
            this.imbGray.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCamera.BackgroundImage = global::EmguCV_Labs.Properties.Resources.webcam_icon;
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera.Location = new System.Drawing.Point(11, 4);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(30, 30);
            this.btnCamera.TabIndex = 5;
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trbHiV);
            this.groupBox1.Controls.Add(this.trbHiS);
            this.groupBox1.Controls.Add(this.trbHiH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trbLowV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trbLowS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trbLowH);
            this.groupBox1.Location = new System.Drawing.Point(11, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSV Threshold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Upper";
            // 
            // trbHiV
            // 
            this.trbHiV.Location = new System.Drawing.Point(178, 109);
            this.trbHiV.Maximum = 255;
            this.trbHiV.Name = "trbHiV";
            this.trbHiV.Size = new System.Drawing.Size(114, 45);
            this.trbHiV.TabIndex = 8;
            this.trbHiV.TickFrequency = 64;
            this.trbHiV.Value = 255;
            this.trbHiV.Scroll += new System.EventHandler(this.trbHiHSV_Scroll);
            // 
            // trbHiS
            // 
            this.trbHiS.Location = new System.Drawing.Point(178, 71);
            this.trbHiS.Maximum = 255;
            this.trbHiS.Name = "trbHiS";
            this.trbHiS.Size = new System.Drawing.Size(114, 45);
            this.trbHiS.TabIndex = 7;
            this.trbHiS.TickFrequency = 64;
            this.trbHiS.Value = 255;
            this.trbHiS.Scroll += new System.EventHandler(this.trbHiHSV_Scroll);
            // 
            // trbHiH
            // 
            this.trbHiH.Location = new System.Drawing.Point(178, 33);
            this.trbHiH.Maximum = 255;
            this.trbHiH.Name = "trbHiH";
            this.trbHiH.Size = new System.Drawing.Size(114, 45);
            this.trbHiH.TabIndex = 6;
            this.trbHiH.TickFrequency = 64;
            this.trbHiH.Value = 255;
            this.trbHiH.Scroll += new System.EventHandler(this.trbHiHSV_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "V";
            // 
            // trbLowV
            // 
            this.trbLowV.Location = new System.Drawing.Point(38, 109);
            this.trbLowV.Maximum = 255;
            this.trbLowV.Name = "trbLowV";
            this.trbLowV.Size = new System.Drawing.Size(114, 45);
            this.trbLowV.TabIndex = 4;
            this.trbLowV.TickFrequency = 64;
            this.trbLowV.Scroll += new System.EventHandler(this.trbLowHSV_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "S";
            // 
            // trbLowS
            // 
            this.trbLowS.Location = new System.Drawing.Point(38, 71);
            this.trbLowS.Maximum = 255;
            this.trbLowS.Name = "trbLowS";
            this.trbLowS.Size = new System.Drawing.Size(114, 45);
            this.trbLowS.TabIndex = 2;
            this.trbLowS.TickFrequency = 64;
            this.trbLowS.Scroll += new System.EventHandler(this.trbLowHSV_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "H";
            // 
            // trbLowH
            // 
            this.trbLowH.Location = new System.Drawing.Point(38, 33);
            this.trbLowH.Maximum = 255;
            this.trbLowH.Name = "trbLowH";
            this.trbLowH.Size = new System.Drawing.Size(114, 45);
            this.trbLowH.TabIndex = 0;
            this.trbLowH.TickFrequency = 64;
            this.trbLowH.Scroll += new System.EventHandler(this.trbLowHSV_Scroll);
            // 
            // trbParam1
            // 
            this.trbParam1.Location = new System.Drawing.Point(91, 33);
            this.trbParam1.Maximum = 256;
            this.trbParam1.Minimum = 1;
            this.trbParam1.Name = "trbParam1";
            this.trbParam1.Size = new System.Drawing.Size(213, 45);
            this.trbParam1.TabIndex = 7;
            this.trbParam1.TickFrequency = 64;
            this.trbParam1.Value = 100;
            this.trbParam1.Scroll += new System.EventHandler(this.trbParam_Scroll);
            // 
            // trbParam2
            // 
            this.trbParam2.Location = new System.Drawing.Point(91, 84);
            this.trbParam2.Maximum = 256;
            this.trbParam2.Minimum = 1;
            this.trbParam2.Name = "trbParam2";
            this.trbParam2.Size = new System.Drawing.Size(213, 45);
            this.trbParam2.TabIndex = 8;
            this.trbParam2.TickFrequency = 64;
            this.trbParam2.Value = 80;
            this.trbParam2.Scroll += new System.EventHandler(this.trbParam_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Threshold :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Threshold2 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trbParam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trbParam1);
            this.groupBox2.Location = new System.Drawing.Point(338, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circle Theshold";
            // 
            // Lab08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.imbGray);
            this.Controls.Add(this.imbColor);
            this.Name = "Lab08";
            this.Text = "Circle Detect";
            this.Load += new System.EventHandler(this.Lab08_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbGray)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHiH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLowH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbParam2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imbColor;
        private Emgu.CV.UI.ImageBox imbGray;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trbLowV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbLowS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbLowH;
        private System.Windows.Forms.TrackBar trbHiV;
        private System.Windows.Forms.TrackBar trbHiS;
        private System.Windows.Forms.TrackBar trbHiH;
        private System.Windows.Forms.TrackBar trbParam1;
        private System.Windows.Forms.TrackBar trbParam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}