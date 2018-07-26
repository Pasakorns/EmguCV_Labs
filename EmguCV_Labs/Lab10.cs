using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace EmguCV_Labs
{
    public partial class Lab10 : Form
    {
        private static Lab10 _instance;
        public static Lab10 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab10();
                }
                return _instance;
            }
        }

        private const int FRAME_WIDTH = 320;
        private const int FRAME_HEIGHT = 240;
        private const int POSITION_MEMORY_OFFSET = 50;
        VideoCapture video;
        bool playing = false;
        Image<Bgr, byte> frameRgb;
        Image<Gray, byte> frameGray;
        Image<Bgr, byte> frameShow;

        List<Movement> pathV2;
        CvTracks tracker;
        double calScale = 1;

        #region Control panel
        private Lab10()
        {
            InitializeComponent();
        }
        private void Lab10_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Emgu.CV.CvEnum.ThresholdType)))
            {
                cboThresType.Items.Add(item);
            }
            cboThresType.SelectedIndex = 0;

            frameRgb = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
            frameGray = new Image<Gray, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
            frameShow = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
            pathV2 = new List<Movement>(POSITION_MEMORY_OFFSET);
            tracker = new CvTracks();
        }
        private void openVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                video = new VideoCapture("ball.mp4");
                Mat m = new Mat();
                video.Read(m);
                frameRgb = new Image<Bgr, byte>(m.Bitmap).Resize(FRAME_WIDTH, FRAME_HEIGHT, Emgu.CV.CvEnum.Inter.Linear);
                frameGray = ImageFillter(frameRgb);
                frameGray.Convert<Bgr, byte>().CopyTo(frameShow);

                imbInput.Image = frameRgb;
                imbOutput.Image = frameShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playing = true;
                PlayVideo();
            }
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playing = false;
        }
        private void trbThreshold_Scroll(object sender, EventArgs e)
        {
            imbOutput.Image = ImageFillter(frameRgb);
        }
        private void cboThresType_SelectedIndexChanged(object sender, EventArgs e)
        {
            imbOutput.Image = ImageFillter(frameRgb);
        }
        private void nudScale_ValueChanged(object sender, EventArgs e)
        {
            calScale = Convert.ToDouble(nudScale.Value);
        }
        private void nudMaxArea_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxArea.Value <= nudMinArea.Value)
            {
                nudMinArea.Value = nudMaxArea.Value - 1;
            }
        }
        #endregion

        #region program's functions
        private Image<Gray, Byte> ImageFillter(Image<Bgr, byte> sourceImage)
        {
            if (sourceImage != null)
            {
                Image<Gray, Byte> buff = sourceImage.Convert<Gray, Byte>();
                CvInvoke.Threshold(buff, buff, trbThreshold.Value, 255, (Emgu.CV.CvEnum.ThresholdType)cboThresType.SelectedItem);
                buff = buff.Erode(trbErode.Value);
                buff = buff.Dilate(trbDilate.Value);
                return buff;
            }
            else
            {
                return null;
            }
        }
        private async void PlayVideo()
        {
            if (video != null)
            {
                try
                {
                    long spf = Convert.ToInt64(1000/video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                    var times = System.Diagnostics.Stopwatch.StartNew();
                    times.Restart();
                    pathV2.Clear();
                    
                    while (video.QueryFrame() != null && playing)
                    {
                        times.Restart();
                        var timer = StopWatch(times, spf);

                        Image<Bgr, Byte> buffFrame = new Image<Bgr, byte>(video.QueryFrame().Bitmap).Resize(FRAME_WIDTH, 
                                                                                                            FRAME_HEIGHT,
                                                                                                            Emgu.CV.CvEnum.Inter.Linear);
                        imbInput.Image = buffFrame;
                        buffFrame.CopyTo(frameRgb);

                        #region Fillter frame 
                        frameGray = ImageFillter(frameRgb);
                        frameGray.Convert<Bgr, byte>().CopyTo(frameShow);
                        #endregion

                        #region Start tracking
                        CvBlobs buffBlobs = FindObject(frameGray, (int)nudMinArea.Value, (int)nudMaxArea.Value);
                        UpdateTracker(tracker, buffBlobs, 50, 3, 10);
                        Movement nowPos = new Movement();
                        nowPos = SetMovement(tracker, buffBlobs, DateTime.Now);
                        PathUpdateV2(nowPos);
                        DrawPath(ref frameShow);
                        var moveCal = SpeedCalculate(pathV2);
                        #endregion

                        imbOutput.Image = frameShow;
                        await Task.WhenAll(timer);
                        times.Stop();
                    }

                    if (video.QueryFrame() == null)
                    {
                        playing = false;
                        pathV2.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        private CvBlobs FindObject(Image<Gray, byte> inputImg, int minArea, int maxArea)
        {
            if (inputImg != null)
            {
                CvBlobDetector detector = new CvBlobDetector();
                CvBlobs blobs = new CvBlobs();
                
                uint result = detector.Detect(inputImg, blobs);
                blobs.FilterByArea(minArea,maxArea);

                // Draw bounding box
                //if (path.Count > 0 && path != null)
                //{
                //    foreach (var item in path)
                //    {
                //        var buff = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
                //        buff.Draw(new CircleF(item, 3), new Bgr(0, 0, 255), 3);
                //    }
                //}
                return blobs;
            }
            return null;
        }
        private void UpdateTracker(CvTracks blobsTracker, CvBlobs blobs, double thDistance, uint thInactive, uint thActive)
        {
            if (blobs != null && blobs.Count > 0)
            {
                blobsTracker.Update(blobs, thDistance, thInactive, thActive);
            }
            else
            {
                MessageBox.Show("Blob track error");
            }
            // Draw bounding box
            var buff = new Image<Gray, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
            foreach (var item in blobsTracker)
            {
                buff.Draw(item.Value.BoundingBox, new Gray(255), 2);
                
            }
            frameShow.SetValue(new Bgr(0, 0, 255), buff);
            /////////////////////
        }
        private Movement SetMovement(CvTracks trackedBlobs, CvBlobs inputBolbs, DateTime now)
        {
            Movement path = new Movement();
            if (inputBolbs != null && trackedBlobs != null && inputBolbs.Count > 0 && trackedBlobs.Count > 0)
            {
                foreach (var item in trackedBlobs)
                {
                    path.position = inputBolbs[item.Value.Id].Centroid;
                    path.boundingBox = inputBolbs[item.Value.Id].BoundingBox;
                    path.time = now;
                }
            }
            return path;
        }
        private void PathUpdateV2(Movement nowPos)
        {

            if (pathV2.Count > POSITION_MEMORY_OFFSET)
            {
                pathV2.RemoveAt(0);
            }
            pathV2.Add(nowPos);
        }
        private void DrawPath(ref Image<Bgr, byte> outImg)
        {
            if (pathV2.Count > 1)
            {
                var buff = new Image<Gray, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));

                for (int i = 0; i < pathV2.Count - 1; i++)
                {
                    buff.Draw(new LineSegment2DF(pathV2[i].position, pathV2[i + 1].position), new Gray(255), 1);
                }

                outImg.SetValue(new Bgr(255, 255, 0), buff);
            }
        }
        private async Task StopWatch(System.Diagnostics.Stopwatch elaps, long sp)
        {
            while (true)
            {
                if (elaps.ElapsedMilliseconds >= sp)
                {
                    break;
                }
                else
                {
                    await Task.Delay(1);
                }
            }
        }
        private async Task SpeedCalculate(List<Movement> path)
        {
            if (path.Count > 5 && path != null)
            {
                double distance = 0;
                double totalTime = 0;
                double speed = 0;
                for (int i = path.Count - 1; i > path.Count - 5; i--)
                {
                    float dX = Math.Abs(path[i].position.X - path[i - 1].position.X);
                    float dY = Math.Abs(path[i].position.Y - path[i - 1].position.Y);
                    distance += Math.Sqrt(dX * dX + dY * dY);
                    totalTime += Math.Abs((path[i - 1].time - path[i].time).TotalSeconds);
                    if (totalTime > 0)
                    {
                        speed = (distance*calScale) / totalTime;
                    }
                }
                lblSpeed.Text = speed.ToString("0.###");
                lblDistance.Text = distance.ToString("0.###");
                lblTime.Text = totalTime.ToString("0.###");
            }
        }
        #endregion

        private struct Movement
        {
            public PointF position;
            public System.Drawing.Rectangle boundingBox;
            public DateTime time;
        }

    }
}
