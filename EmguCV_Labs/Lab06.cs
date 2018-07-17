using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_Labs
{
    public partial class Lab06 : Form
    {
        private static Lab06 _instance;
        public static Lab06 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab06();
                }
                return _instance;
            }
        }

        VideoCapture cap;
        Mat frame;
        Image<Gray, Byte> blank;
        bool pause = false;

        public Lab06()
        {
            InitializeComponent();
        }

        private void Lab06_Load(object sender, EventArgs e)
        {
            blank = new Image<Gray, byte>(pboDisplay.Width, pboDisplay.Height,new Gray(0));
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
                pause = false;
                VideoPlayer();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                pause = false;
                VideoPlayer();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                pause = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cap != null)
            {
                cap.Dispose();
                pboDisplay.Image = blank.ToBitmap();
            }
        }

        private async void VideoPlayer()
        {
            if (cap != null)
            {
                try
                {
                    double fps = cap.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);

                    while (!pause && cap.QueryFrame() != null)
                    {
                        frame = cap.QueryFrame();
                        Image<Bgr, Byte> img = new Image<Bgr, byte>(frame.Bitmap);
                        pboDisplay.Image = img.ToBitmap(pboDisplay.Width, pboDisplay.Height);
                        await Task.Delay(Convert.ToInt32(1000 / fps));
                        frame.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
               return;
            }
        }
    }
}
