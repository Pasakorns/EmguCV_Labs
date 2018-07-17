using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace EmguCV_Labs
{
    public partial class Lab07 : Form
    {
        private static Lab07 _instance;
        public static Lab07 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab07();
                }
                return _instance;
            }
        }

        Image<Bgr, Byte> originImg;
        Image<Gray, Byte> inputImg;
        Emgu.CV.Util.VectorOfVectorOfPoint contours;
        Image<Gray, Byte> blank;
        Image<Gray, Byte> resultImg;

        public Lab07()
        {
            InitializeComponent();
        }

        private void Lab07_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(RetrType)))
            {
                cboRetry.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(ChainApproxMethod)))
            {
                cboApprox.Items.Add(item);
            }

            cboRetry.SelectedIndex = 0;
            cboApprox.SelectedIndex = 2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originImg = new Image<Bgr, byte>(ofd.FileName);
                originImg = originImg.Resize(1600, 1200, Emgu.CV.CvEnum.Inter.Linear, true);
                Image<Bgr, byte> displayImg = originImg.Resize(imbOrigin.Width, imbOrigin.Height, Emgu.CV.CvEnum.Inter.Linear, true);
                imbOrigin.Image = displayImg;
                blank = new Image<Gray, byte>(originImg.Width, originImg.Height, new Gray(0));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originImg != null)
            {
                MyFindContours();
                MyDrawContours();
                UpdateResult();
            }
        }

        private void MyFindContours()
        {
            if (originImg != null)
            {
                inputImg = originImg.Convert<Gray, Byte>().ThresholdBinary(new Gray((double)nudThreshold.Value), new Gray(255));
                contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                Mat hire = new Mat();
                try
                {
                    CvInvoke.FindContours(inputImg, contours, hire, (RetrType)cboRetry.SelectedItem, (ChainApproxMethod)cboApprox.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MyDrawContours()
        {
            resultImg = new Image<Gray, byte>(originImg.Width, originImg.Height, new Gray(0));
            if (contours != null && contours.Size > 0)
            {
                CvInvoke.DrawContours(resultImg, contours, -1, new MCvScalar(255, 0, 0));

            }
            imbContour.Image = resultImg.Resize(imbContour.Width, imbContour.Height, Inter.Linear, true);
        }

        private void MyDrawContours(int index)
        {
            resultImg = new Image<Gray, byte>(originImg.Width, originImg.Height, new Gray(0));
            if (contours != null && contours.Size > 0)
            {
                CvInvoke.DrawContours(resultImg, contours, index, new MCvScalar(255, 0, 0), 5);

            }
            imbContour.Image = resultImg.Resize(imbContour.Width, imbContour.Height, Inter.Linear, true);
        }

        private void UpdateResult()
        {
            if (contours != null)
            {
                lblFoundNo.Text = contours.Size.ToString();

                cboContoursId.Items.Clear();
                cboContoursId.Items.Add(-1);
                for (int i = 0; i < contours.Size; i++)
                {
                    cboContoursId.Items.Add(i.ToString());
                }
                cboContoursId.SelectedIndex = 0;
            }

        }

        private void cboContoursId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contours != null && contours.Size > 0)
            {
                int index = Convert.ToInt32(cboContoursId.Text);
                MyDrawContours(index);

                if (index >= 0)
                {
                    double area = CvInvoke.ContourArea(contours[index]);
                    double xPos = CvInvoke.Moments(contours[index]).GravityCenter.X;
                    double yPos = CvInvoke.Moments(contours[index]).GravityCenter.Y;
                    resultImg.Draw(new CircleF(new PointF((float)xPos, (float)yPos), 5),new Gray(255), 10);         // Draw CG point
                    imbContour.Image = resultImg.Resize(imbContour.Width, imbContour.Height, Inter.Linear, true);  

                    lblArea.Text = area.ToString();
                    lblXpos.Text = xPos.ToString("0.##");
                    lblYpos.Text = yPos.ToString("0.##");
                }
                else
                {
                    lblArea.Text = "---";
                    lblXpos.Text = "---";
                    lblYpos.Text = "---";
                }

            }
        }
    }
}
