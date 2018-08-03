using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_Labs
{
    public partial class Lab11 : Form
    {
        private static Lab11 _instance;
        public static Lab11 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab11();
                }
                return _instance;
            }
        }

        private const int FRAME_WIDTH = 320;
        private const int FRAME_HEIGHT = 240;
        private Size imgSize = new Size(FRAME_WIDTH, FRAME_HEIGHT);
        Image<Bgr, byte> sourceImage = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
        Image<Bgr, byte> resultImage = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
        int curX = 0;
        int curY = 0;

        Point[] corner = { new Point(10, 10),
                            new Point(100, 10),
                            new Point(10, 100),
                            new Point(100, 100)
                          };

        private Lab11()
        {
            InitializeComponent();
        }

        private void Lab11_Load(object sender, EventArgs e)
        {
            imbSoucre.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            imbResult.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Mat input = CvInvoke.Imread(ofd.FileName, Emgu.CV.CvEnum.ImreadModes.AnyColor);


                CvInvoke.Resize(input, sourceImage, imgSize);

                imbSoucre.Image = sourceImage;
            }
        }

        private void imbSoucre_MouseMove(object sender, MouseEventArgs e)
        {
            curX = e.X;
            curY = e.Y;
            lblXCursor.Text = curX.ToString();
            lblYCursor.Text = curY.ToString();
        }

        private void imbSoucre_MouseLeave(object sender, EventArgs e)
        {
            lblXCursor.Text = "---";
            lblYCursor.Text = "---";
        }

        private void nudPXY_ValueChanged(object sender, EventArgs e)
        {
            corner[0].X = (Int32)nudP0X.Value;
            corner[0].Y = (Int32)nudP0Y.Value;
            corner[1].X = (Int32)nudP1X.Value;
            corner[1].Y = (Int32)nudP1Y.Value;
            corner[2].X = (Int32)nudP2X.Value;
            corner[2].Y = (Int32)nudP2Y.Value;
            corner[3].X = (Int32)nudP3X.Value;
            corner[3].Y = (Int32)nudP3Y.Value;

            Mat buff = new Mat();
            sourceImage.Mat.CopyTo(buff);
            var mask = GetPolygonMask(corner);
            buff.SetTo(new MCvScalar(0, 0, 255), mask);
            imbSoucre.Image = buff;
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            PerspectiveTransform();

            imbResult.Image = resultImage;
        }

        private Mat GetPolygonMask(Point[] points)
        {
            Mat img = new Mat(imgSize, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
            img.SetTo(new MCvScalar(0));
            CvInvoke.Line(img, points[0], points[1], new MCvScalar(255), 2);
            CvInvoke.Line(img, points[1], points[2], new MCvScalar(255), 2);
            CvInvoke.Line(img, points[2], points[3], new MCvScalar(255), 2);
            CvInvoke.Line(img, points[3], points[0], new MCvScalar(255), 2);

            return img;
        }

        private void PerspectiveTransform()
        {
            PointF[] sourceP = Array.ConvertAll(corner, item => (PointF)item);
            PointF[] dstP = { new PointF(0, 0),
                              new PointF(FRAME_WIDTH-1, 0), 
                              new PointF(FRAME_WIDTH-1, FRAME_HEIGHT-1), 
                              new PointF(0, FRAME_HEIGHT-1)
                            };

            var calMat = CvInvoke.GetPerspectiveTransform(sourceP, dstP);

            CvInvoke.WarpPerspective(sourceImage, resultImage, calMat, imgSize);
        }

    }

    public class MyPolygon
    {

    }
}
