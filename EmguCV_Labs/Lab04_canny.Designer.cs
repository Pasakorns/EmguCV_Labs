namespace EmguCV_Labs
{
    partial class Lab04_canny
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
            this.tbaThreshold1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbaThreshold2 = new System.Windows.Forms.TrackBar();
            this.lblThreshold1 = new System.Windows.Forms.Label();
            this.lblThreshold2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOff = new System.Windows.Forms.RadioButton();
            this.rdoOn = new System.Windows.Forms.RadioButton();
            this.lblApertureSize = new System.Windows.Forms.Label();
            this.trbApertureSize = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbApertureSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbaThreshold1
            // 
            this.tbaThreshold1.Location = new System.Drawing.Point(104, 22);
            this.tbaThreshold1.Maximum = 100;
            this.tbaThreshold1.Name = "tbaThreshold1";
            this.tbaThreshold1.Size = new System.Drawing.Size(351, 45);
            this.tbaThreshold1.TabIndex = 0;
            this.tbaThreshold1.TickFrequency = 20;
            this.tbaThreshold1.Value = 20;
            this.tbaThreshold1.Scroll += new System.EventHandler(this.tbaThreshold1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1st Threshold :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Threshold :";
            // 
            // tbaThreshold2
            // 
            this.tbaThreshold2.Location = new System.Drawing.Point(104, 73);
            this.tbaThreshold2.Maximum = 100;
            this.tbaThreshold2.Name = "tbaThreshold2";
            this.tbaThreshold2.Size = new System.Drawing.Size(351, 45);
            this.tbaThreshold2.TabIndex = 5;
            this.tbaThreshold2.TickFrequency = 20;
            this.tbaThreshold2.Value = 50;
            this.tbaThreshold2.Scroll += new System.EventHandler(this.tbaThreshold1_Scroll);
            // 
            // lblThreshold1
            // 
            this.lblThreshold1.BackColor = System.Drawing.Color.White;
            this.lblThreshold1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThreshold1.Location = new System.Drawing.Point(462, 22);
            this.lblThreshold1.Name = "lblThreshold1";
            this.lblThreshold1.Size = new System.Drawing.Size(40, 20);
            this.lblThreshold1.TabIndex = 6;
            this.lblThreshold1.Text = "20";
            this.lblThreshold1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreshold2
            // 
            this.lblThreshold2.BackColor = System.Drawing.Color.White;
            this.lblThreshold2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThreshold2.Location = new System.Drawing.Point(462, 75);
            this.lblThreshold2.Name = "lblThreshold2";
            this.lblThreshold2.Size = new System.Drawing.Size(40, 20);
            this.lblThreshold2.TabIndex = 7;
            this.lblThreshold2.Text = "50";
            this.lblThreshold2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apertur size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "L2Gradiant :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOn);
            this.groupBox1.Controls.Add(this.rdoOff);
            this.groupBox1.Location = new System.Drawing.Point(352, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 42);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rdoOff
            // 
            this.rdoOff.AutoSize = true;
            this.rdoOff.Checked = true;
            this.rdoOff.Location = new System.Drawing.Point(14, 15);
            this.rdoOff.Name = "rdoOff";
            this.rdoOff.Size = new System.Drawing.Size(45, 17);
            this.rdoOff.TabIndex = 0;
            this.rdoOff.TabStop = true;
            this.rdoOff.Text = "OFF";
            this.rdoOff.UseVisualStyleBackColor = true;
            // 
            // rdoOn
            // 
            this.rdoOn.AutoSize = true;
            this.rdoOn.Location = new System.Drawing.Point(72, 15);
            this.rdoOn.Name = "rdoOn";
            this.rdoOn.Size = new System.Drawing.Size(41, 17);
            this.rdoOn.TabIndex = 1;
            this.rdoOn.TabStop = true;
            this.rdoOn.Text = "ON";
            this.rdoOn.UseVisualStyleBackColor = true;
            // 
            // lblApertureSize
            // 
            this.lblApertureSize.BackColor = System.Drawing.Color.White;
            this.lblApertureSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApertureSize.Location = new System.Drawing.Point(184, 33);
            this.lblApertureSize.Name = "lblApertureSize";
            this.lblApertureSize.Size = new System.Drawing.Size(20, 20);
            this.lblApertureSize.TabIndex = 12;
            this.lblApertureSize.Text = "3";
            this.lblApertureSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbApertureSize
            // 
            this.trbApertureSize.LargeChange = 6;
            this.trbApertureSize.Location = new System.Drawing.Point(83, 31);
            this.trbApertureSize.Maximum = 3;
            this.trbApertureSize.Minimum = 1;
            this.trbApertureSize.Name = "trbApertureSize";
            this.trbApertureSize.Size = new System.Drawing.Size(96, 45);
            this.trbApertureSize.TabIndex = 11;
            this.trbApertureSize.Value = 1;
            this.trbApertureSize.Scroll += new System.EventHandler(this.tbaThreshold1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblApertureSize);
            this.groupBox2.Controls.Add(this.trbApertureSize);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Lab04_canny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblThreshold2);
            this.Controls.Add(this.lblThreshold1);
            this.Controls.Add(this.tbaThreshold2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbaThreshold1);
            this.Name = "Lab04_canny";
            this.Text = "Canny Edge Detection";
            this.Load += new System.EventHandler(this.Lab04_canny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaThreshold2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbApertureSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbaThreshold1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbaThreshold2;
        private System.Windows.Forms.Label lblThreshold1;
        private System.Windows.Forms.Label lblThreshold2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOn;
        private System.Windows.Forms.RadioButton rdoOff;
        private System.Windows.Forms.Label lblApertureSize;
        private System.Windows.Forms.TrackBar trbApertureSize;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}