using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_Labs
{
    public partial class Lab03 : Form
    {
        private static Lab03 _instance;
        public static Lab03 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab03();
                }
                return _instance;
            }
        }

        private Image<Bgr, Byte> imageRGB;

        public Lab03()
        {
            InitializeComponent();
        }

        private void Lab03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> inputImg = new Image<Bgr, byte>(ofd.FileName);
                panAndZoomPictureBox1.Image = inputImg.ToBitmap();

                imageRGB = inputImg;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageRGB != null)
            {
                DenseHistogram histRed = new DenseHistogram(256, new RangeF(0, 255));
                DenseHistogram histGrn = new DenseHistogram(256, new RangeF(0, 255));
                DenseHistogram histBlu = new DenseHistogram(256, new RangeF(0, 255));

                histRed.Calculate(new Image<Gray, Byte>[] { imageRGB[2] }, false, null);
                histGrn.Calculate(new Image<Gray, Byte>[] { imageRGB[1] }, false, null);
                histBlu.Calculate(new Image<Gray, Byte>[] { imageRGB[0] }, false, null);

                Mat histBuffer = new Mat();

                histRed.CopyTo(histBuffer);
                htgRed.ClearHistogram();
                htgRed.AddHistogram("Red Histrogram", Color.Red, histBuffer, 256, new float[] { 0, 256 });
                htgRed.Refresh();

                histGrn.CopyTo(histBuffer);
                htgGreen.ClearHistogram();
                htgGreen.AddHistogram("Red Histrogram", Color.Green, histBuffer, 256, new float[] { 0, 256 });
                htgGreen.Refresh();

                histBlu.CopyTo(histBuffer);
                htgBlue.ClearHistogram();
                htgBlue.AddHistogram("Red Histrogram", Color.Blue, histBuffer, 256, new float[] { 0, 256 });
                htgBlue.Refresh();
            }
            else
            {
                MessageBox.Show("No image found!");
            }
        }
    }
}
