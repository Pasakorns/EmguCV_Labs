namespace EmguCV_Labs
{
    partial class Lab04
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnCanny = new System.Windows.Forms.Button();
            this.btnLaplacian = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pboImage = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(573, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 46);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(17, 71);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(75, 30);
            this.btnSobel.TabIndex = 2;
            this.btnSobel.Text = "SOBEL";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnCanny
            // 
            this.btnCanny.Location = new System.Drawing.Point(17, 27);
            this.btnCanny.Name = "btnCanny";
            this.btnCanny.Size = new System.Drawing.Size(75, 30);
            this.btnCanny.TabIndex = 3;
            this.btnCanny.Text = "CANNY";
            this.btnCanny.UseVisualStyleBackColor = true;
            this.btnCanny.Click += new System.EventHandler(this.btnCanny_Click);
            // 
            // btnLaplacian
            // 
            this.btnLaplacian.Location = new System.Drawing.Point(16, 115);
            this.btnLaplacian.Name = "btnLaplacian";
            this.btnLaplacian.Size = new System.Drawing.Size(75, 30);
            this.btnLaplacian.TabIndex = 4;
            this.btnLaplacian.Text = "LAPLACIAN";
            this.btnLaplacian.UseVisualStyleBackColor = true;
            this.btnLaplacian.Click += new System.EventHandler(this.btnLaplacian_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(574, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLaplacian);
            this.groupBox1.Controls.Add(this.btnCanny);
            this.groupBox1.Controls.Add(this.btnSobel);
            this.groupBox1.Location = new System.Drawing.Point(557, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detect type";
            // 
            // pboImage
            // 
            this.pboImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboImage.Location = new System.Drawing.Point(12, 12);
            this.pboImage.Name = "pboImage";
            this.pboImage.Size = new System.Drawing.Size(530, 330);
            this.pboImage.TabIndex = 0;
            this.pboImage.TabStop = false;
            // 
            // Lab04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pboImage);
            this.Name = "Lab04";
            this.Text = "Edge Detection";
            this.Load += new System.EventHandler(this.Lab04_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.PanAndZoomPictureBox pboImage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnCanny;
        private System.Windows.Forms.Button btnLaplacian;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}