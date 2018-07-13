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
    public partial class Lab01 : Form
    {
        private static Lab01 _instance;
        public static Lab01 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab01();
                }
                return _instance;
            }
        }

        private Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                Image<Bgr, Byte> image = new Image<Bgr, byte>(openFile.FileName); // instance of your image

                iboImageBox.Image = image;
                iboImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Everything; //Enable/Disable functions of ImageBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                Mat img = CvInvoke.Imread(openFile.FileName, Emgu.CV.CvEnum.ImreadModes.AnyColor); // instance of your image
                pboPictureBox.Image = img.Bitmap;

                /// or
                // Image<Bgr, Byte> image = new Image<Bgr, byte>(openFile.FileName);
                // pboPictureBox.Image = image.ToBitmap();
            }
        }
    }
}
