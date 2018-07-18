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
    
    public partial class Lab08 : Form
    {
        private static Lab08 _instance;
        public static Lab08 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab08();
                }
                return _instance;
            }
        }

        private const int FRAME_WIDTH = 320;
        private const int FRAME_HEIGHT = 240;

        private Image<Bgr, Byte> sourceImg;
        private Image<Gray, Byte> pfImg;
        private Image<Bgr, Byte> showImg;
        private double xPos = 0;
        private double yPos = 0;
        private double area = 0;
        private double rad = 0;
        private int low_H = 0;
        private int low_S = 0;
        private int low_V = 0;
        private int hi_H = 255;
        private int hi_S = 255;
        private int hi_V = 255;

        private double cannyThreshold = 100.0;
        private double circleAccumulatorThreshold = 80;
        private int minRadious = 10;
        private int maxRadious = 100;

        private VideoCapture cap;

        public Lab08()
        {
            InitializeComponent();
        }

        private void Lab08_Load(object sender, EventArgs e)
        {

        }

        private void ImgFillter()
        {
            Image<Hsv, Byte> buffImg = sourceImg.Convert<Hsv, Byte>();
            
            var buffImg2 = buffImg.InRange( new Hsv(low_V,low_S,low_H), new Hsv(hi_V, hi_S, hi_H));     

            imbGray.Image = buffImg2;

            pfImg = buffImg2.Canny(cannyThreshold,255);
        }

        private bool FindCircle()
        {
            if (pfImg != null)
            {
                var buffImg = sourceImg;
                CircleF[] circles = CvInvoke.HoughCircles(pfImg, Emgu.CV.CvEnum.HoughType.Gradient, 2, 100, 100, circleAccumulatorThreshold, minRadious, maxRadious);
                if (circles.Length > 0 && circles != null)
                {
                    foreach (var item in circles)
                    {
                        buffImg.Draw(item, new Bgr(0, 0, 255), 3);
                        xPos = item.Center.X;
                        yPos = item.Center.Y;
                        area = item.Area;
                        rad = item.Radius;

                        buffImg.Draw("X :" + xPos, new Point(10, 20), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1,new Bgr(0,0,255)); 
                        buffImg.Draw("Y :" + yPos, new Point(10, 40), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new Bgr(0, 0, 255)); 
                        buffImg.Draw("Area :" + area, new Point(10, 60), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new Bgr(0, 0, 255));
                        buffImg.Draw("Radius :" + rad, new Point(10, 80), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new Bgr(0, 0, 255));
                    }
                    showImg = buffImg;
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private async void ShowImgResult()
        {
            imbColor.Image = showImg;
            await Task.Delay(0);
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            cap = new VideoCapture(0);
            cap.ImageGrabbed += Cap_ImageGrabbed;
            cap.Start();
        }

        private async void Cap_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            cap.Retrieve(frame);
            if (sourceImg != null)
            {
                sourceImg.Dispose();
            }
            sourceImg = frame.ToImage<Bgr, Byte>().Resize(FRAME_WIDTH, FRAME_HEIGHT, Emgu.CV.CvEnum.Inter.Linear);
    
            ImgFillter();
            var circleFound = FindCircle();
            if (circleFound)
            {
                ShowImgResult();
            }

            await Task.Delay(1);
        }

        private void trbLowHSV_Scroll(object sender, EventArgs e)
        {
            low_H = trbLowH.Value;
            if (low_H > hi_H)
            {
                low_H = hi_H;
                trbLowH.Value = hi_H;
            }

            low_S = trbLowS.Value;
            if (low_S > hi_S)
            {
                low_S = hi_S;
                trbLowS.Value = hi_S;
            }

            low_V = trbLowV.Value;

            if (low_V > hi_V)
            {
                low_V = hi_V;
                trbLowV.Value = hi_V;
            }
           
        }

        private void trbHiHSV_Scroll(object sender, EventArgs e)
        {
            hi_H = trbHiH.Value;
            if (low_H > hi_H)
            {
                hi_H = low_H;
                trbHiH.Value = low_H;
            }

            hi_S = trbHiS.Value;
            if (low_S > hi_S)
            {
                hi_S = low_S;
                trbHiS.Value = low_S;
            }

            hi_V = trbHiV.Value;

            if (low_V > hi_V)
            {
                hi_V = low_V;
                trbHiV.Value = low_V;
            }
        }

        private void trbParam_Scroll(object sender, EventArgs e)
        {
            cannyThreshold = trbParam1.Value;
            circleAccumulatorThreshold = trbParam2.Value;
        }
    }
}
