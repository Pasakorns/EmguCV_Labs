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
    public partial class Lab04 : Form
    {
        private static Lab04 _instance;
        public static Lab04 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab04();
                }
                return _instance;
            }
        }

        private Image<Rgb, Byte> _inputImg;
        private Image<Gray, Byte> _grayImg;

        //public static Mat ImgBuffer;

        public Lab04()
        {
            InitializeComponent();
        }

        private void Lab04_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _inputImg = new Image<Rgb, byte>(ofd.FileName);
                pboImage.Image = _inputImg.ToBitmap(pboImage.Width,pboImage.Height);
                _grayImg = _inputImg.Convert<Gray, Byte>();
            }
        }

        private void btnCanny_Click(object sender, EventArgs e)
        {
            Lab04_canny.Instance.ShowDialog();

        }

        private void btnLaplacian_Click(object sender, EventArgs e)
        {
            Lab04_laplaciant.Instance.ShowDialog();
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            Lab04_sobel.Instance.ShowDialog();
        }

        public void Canny(double threshold1, double threshold2, int apertureSize = 3, bool l2Gradiant = false)
        {
            if (_inputImg != null)
            {
                _grayImg = _inputImg.Convert<Gray, Byte>();
                pboImage.Image = _grayImg.Canny(threshold1, threshold2, apertureSize, l2Gradiant).ToBitmap(pboImage.Width, pboImage.Height);
            }
            else
            {
                MessageBox.Show("Please select image before");
            }
        }

        public void Sobel(int Xorder, int Yorder, int ApertureSize)
        {
            if (_inputImg != null)
            {
                _grayImg = _inputImg.Convert<Gray, Byte>();
                pboImage.Image = _grayImg.Sobel(Xorder, Yorder, ApertureSize).ToBitmap(pboImage.Width, pboImage.Height);
            }
            else
            {
                MessageBox.Show("Please select image before");
            }
        }

        public void Laplacian(int ApertureSize)
        {
            if (_inputImg != null)
            {
                _grayImg = _inputImg.Convert<Gray, Byte>();
                pboImage.Image = _grayImg.Laplace(ApertureSize).ToBitmap(pboImage.Width, pboImage.Height);
            }
            else
            {
                MessageBox.Show("Please select image before");
            }
        }
    }
}
