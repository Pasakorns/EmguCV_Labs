namespace EmguCV_Labs
{
    partial class Lab02
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMValue = new System.Windows.Forms.Label();
            this.lblMSize = new System.Windows.Forms.Label();
            this.tbrMValue = new System.Windows.Forms.TrackBar();
            this.tbrMSize = new System.Windows.Forms.TrackBar();
            this.cboAdapType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAdapEn = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbaThreshold = new System.Windows.Forms.TrackBar();
            this.pboGray = new System.Windows.Forms.PictureBox();
            this.pboColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSample1 = new System.Windows.Forms.Button();
            this.btnSample2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMValue);
            this.groupBox1.Controls.Add(this.lblMSize);
            this.groupBox1.Controls.Add(this.tbrMValue);
            this.groupBox1.Controls.Add(this.tbrMSize);
            this.groupBox1.Controls.Add(this.cboAdapType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboAdapEn);
            this.groupBox1.Location = new System.Drawing.Point(376, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold Adaptive";
            // 
            // lblMValue
            // 
            this.lblMValue.AutoSize = true;
            this.lblMValue.BackColor = System.Drawing.Color.White;
            this.lblMValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMValue.Location = new System.Drawing.Point(281, 97);
            this.lblMValue.Name = "lblMValue";
            this.lblMValue.Size = new System.Drawing.Size(18, 15);
            this.lblMValue.TabIndex = 15;
            this.lblMValue.Text = "---";
            // 
            // lblMSize
            // 
            this.lblMSize.AutoSize = true;
            this.lblMSize.BackColor = System.Drawing.Color.White;
            this.lblMSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMSize.Location = new System.Drawing.Point(281, 65);
            this.lblMSize.Name = "lblMSize";
            this.lblMSize.Size = new System.Drawing.Size(18, 15);
            this.lblMSize.TabIndex = 14;
            this.lblMSize.Text = "---";
            // 
            // tbrMValue
            // 
            this.tbrMValue.Enabled = false;
            this.tbrMValue.Location = new System.Drawing.Point(85, 95);
            this.tbrMValue.Maximum = 20;
            this.tbrMValue.Minimum = -20;
            this.tbrMValue.Name = "tbrMValue";
            this.tbrMValue.Size = new System.Drawing.Size(190, 45);
            this.tbrMValue.TabIndex = 13;
            this.tbrMValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrMValue.Scroll += new System.EventHandler(this.tbrMSize_Scroll);
            // 
            // tbrMSize
            // 
            this.tbrMSize.Enabled = false;
            this.tbrMSize.Location = new System.Drawing.Point(85, 61);
            this.tbrMSize.Maximum = 200;
            this.tbrMSize.Minimum = 1;
            this.tbrMSize.Name = "tbrMSize";
            this.tbrMSize.Size = new System.Drawing.Size(190, 45);
            this.tbrMSize.TabIndex = 12;
            this.tbrMSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrMSize.Value = 3;
            this.tbrMSize.Scroll += new System.EventHandler(this.tbrMSize_Scroll);
            // 
            // cboAdapType
            // 
            this.cboAdapType.Enabled = false;
            this.cboAdapType.FormattingEnabled = true;
            this.cboAdapType.Location = new System.Drawing.Point(77, 27);
            this.cboAdapType.Name = "cboAdapType";
            this.cboAdapType.Size = new System.Drawing.Size(94, 21);
            this.cboAdapType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mask value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mask size:";
            // 
            // cboAdapEn
            // 
            this.cboAdapEn.AutoSize = true;
            this.cboAdapEn.Location = new System.Drawing.Point(12, 29);
            this.cboAdapEn.Name = "cboAdapEn";
            this.cboAdapEn.Size = new System.Drawing.Size(59, 17);
            this.cboAdapEn.TabIndex = 6;
            this.cboAdapEn.Text = "Enable";
            this.cboAdapEn.UseVisualStyleBackColor = true;
            this.cboAdapEn.CheckedChanged += new System.EventHandler(this.cboAdapEn_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbaThreshold
            // 
            this.tbaThreshold.Location = new System.Drawing.Point(11, 78);
            this.tbaThreshold.Maximum = 255;
            this.tbaThreshold.Name = "tbaThreshold";
            this.tbaThreshold.Size = new System.Drawing.Size(268, 45);
            this.tbaThreshold.TabIndex = 12;
            this.tbaThreshold.TickFrequency = 32;
            this.tbaThreshold.Value = 100;
            this.tbaThreshold.Scroll += new System.EventHandler(this.tbaThreshold_Scroll);
            // 
            // pboGray
            // 
            this.pboGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboGray.Location = new System.Drawing.Point(376, 47);
            this.pboGray.Name = "pboGray";
            this.pboGray.Size = new System.Drawing.Size(330, 240);
            this.pboGray.TabIndex = 11;
            this.pboGray.TabStop = false;
            // 
            // pboColor
            // 
            this.pboColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboColor.Location = new System.Drawing.Point(12, 47);
            this.pboColor.Name = "pboColor";
            this.pboColor.Size = new System.Drawing.Size(330, 240);
            this.pboColor.TabIndex = 10;
            this.pboColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(289, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "100";
            // 
            // btnSample1
            // 
            this.btnSample1.Location = new System.Drawing.Point(170, 10);
            this.btnSample1.Name = "btnSample1";
            this.btnSample1.Size = new System.Drawing.Size(80, 23);
            this.btnSample1.TabIndex = 19;
            this.btnSample1.Text = "Img sample01";
            this.btnSample1.UseVisualStyleBackColor = true;
            this.btnSample1.Click += new System.EventHandler(this.btnSample1_Click);
            // 
            // btnSample2
            // 
            this.btnSample2.Location = new System.Drawing.Point(262, 10);
            this.btnSample2.Name = "btnSample2";
            this.btnSample2.Size = new System.Drawing.Size(80, 23);
            this.btnSample2.TabIndex = 20;
            this.btnSample2.Text = "Img sample02";
            this.btnSample2.UseVisualStyleBackColor = true;
            this.btnSample2.Click += new System.EventHandler(this.btnSample2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.tbaThreshold);
            this.groupBox2.Location = new System.Drawing.Point(13, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 141);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Threshold";
            // 
            // Lab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSample2);
            this.Controls.Add(this.btnSample1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pboGray);
            this.Controls.Add(this.pboColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Lab02";
            this.Text = "Lab 02 : Image Binarize";
            this.Load += new System.EventHandler(this.Lab02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMValue;
        private System.Windows.Forms.Label lblMSize;
        private System.Windows.Forms.TrackBar tbrMValue;
        private System.Windows.Forms.TrackBar tbrMSize;
        private System.Windows.Forms.ComboBox cboAdapType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboAdapEn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TrackBar tbaThreshold;
        private System.Windows.Forms.PictureBox pboGray;
        private System.Windows.Forms.PictureBox pboColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSample1;
        private System.Windows.Forms.Button btnSample2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}