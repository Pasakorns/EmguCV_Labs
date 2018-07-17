using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_Labs
{
    public partial class Lab05 : Form
    {
        private static Lab05 _instance;
        public static Lab05 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab05();
                }
                return _instance;
            }
        }

        VideoCapture cap;
        Mat frame;
        Image<Bgr, Byte> img;

        public Lab05()
        {
            InitializeComponent();
        }

        private void Lab05_Load(object sender, EventArgs e)
        {
            frame = new Mat();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                cap.Dispose();
            }

            cap = new VideoCapture(0);
            cap.ImageGrabbed += Cap_ImageGrabbed;
            cap.Start();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (cap != null)
                {
                    cap.Dispose();
                }
               
                cap = new VideoCapture(ofd.FileName);

                cap.ImageGrabbed += Cap_ImageGrabbed;
                cap.Start();
            }
        }

        private void Cap_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                cap.Retrieve(frame);
                img = frame.ToImage<Bgr, Byte>();
                pboDisplay.Image = img.ToBitmap(pboDisplay.Width,pboDisplay.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                cap.Start();
            }
            else
            {
                MessageBox.Show("Please select Video source");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                cap.Pause();
            }
            else
            {
                MessageBox.Show("Please select Video source");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                cap.Stop();
                pboDisplay.Image = new Image<Gray, byte>(pboDisplay.Width,pboDisplay.Height,new Gray(0)).ToBitmap();
            }
            else
            {
                MessageBox.Show("Please select Video source");
            }
        }
    }
}
