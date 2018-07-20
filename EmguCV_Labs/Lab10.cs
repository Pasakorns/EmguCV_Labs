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

        VideoCapture video;
        bool playing = false;
        bool tracking = false;
        Image<Bgr, byte> frameRgb;
        Image<Gray, byte> frameGray;
        Image<Bgr, byte> frameShow;

        List<PointF> path;
        CvTracks tracker;
        CvBlobs mBlobs;

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
            path = new List<PointF>(50);
            tracker = new CvTracks();
            mBlobs = new CvBlobs();
        }
        private void openVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    video = new VideoCapture(ofd.FileName);
                    Mat m = new Mat();
                    video.Read(m);
                    frameRgb = new Image<Bgr, byte>(m.Bitmap).Resize(FRAME_WIDTH, FRAME_HEIGHT, Emgu.CV.CvEnum.Inter.Linear);
                    imbInput.Image = frameRgb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playing = false;
            if (video != null)
            {
                ///
            }
        }
        private void trbThreshold_Scroll(object sender, EventArgs e)
        {
            imbOutput.Image = ImageFillter(frameRgb);
        }
        private void cboThresType_SelectedIndexChanged(object sender, EventArgs e)
        {
            imbOutput.Image = ImageFillter(frameRgb);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tracking = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            tracking = false;
        }
        #endregion

        #region program's functions
        /// <summary>
        /// Fillering image
        /// </summary>
        /// <returns>Gray image</returns>
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
                        if (tracking)
                        {
                            PathUpdate(FindObject(frameGray));
                            mBlobs = FindObject(frameGray);
                            UpdateTracker(mBlobs);
                            DrawPath(ref frameShow);
                        }
                        else
                        {

                        }
                        #endregion

                        imbOutput.Image = frameShow;
                        await Task.WhenAll(timer);
                        times.Stop();
                    }

                    if (video.QueryFrame() == null)
                    {
                        playing = false;
                        tracking = false;
                        path.Clear();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("QuaryFrame");
                    return;
                }
            }

        }

        private CvBlobs FindObject(Image<Gray, byte> grayImg)
        {
            if (grayImg != null)
            {
                CvBlobDetector detector = new CvBlobDetector();
                CvBlobs blobs = new CvBlobs();
                // detect blob
                uint result = detector.Detect(grayImg, blobs);

                if (blobs.Count > 0 && !blobs.Equals(null))
                {
                    if (path.Count > 50)
                    {
                        path.RemoveAt(0);
                    }
                    path.Add(blobs[1].Centroid);
                }

                if (path.Count > 0 && path != null)
                {
                    foreach (var item in path)
                    {
                        var buff = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
                        buff.Draw(new CircleF(item, 3), new Bgr(0, 0, 255), 3);
                    }
                }

                return blobs;
            }

            return null;
        }

        private void PathUpdate(CvBlobs blobs)
        {
            if (path.Count > 50)
            {
                path.RemoveAt(0);
            }
            path.Add(blobs[1].Centroid);

            if (path.Count > 0 && path != null)
            {
                foreach (var item in path)
                {
                    var buff = new Image<Bgr, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));
                    buff.Draw(new CircleF(item, 3), new Bgr(0, 0, 255), 3);
                }
            }
        }

        private void DrawPath(ref Image<Bgr, byte> outImg)
        {
            if (path.Count > 0 && path != null)
            {
                var buff = new Image<Gray, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));

                foreach (var item in path)
                {
                    buff.Draw(new CircleF(item, 2), new Gray(255), 3);
                }

                outImg.SetValue(new Bgr(0, 0, 255), buff);
            }
        }

        private void UpdateTracker(CvBlobs blobs)
        {
            if (blobs != null)
            {
                //UNDONE: need exception
                tracker.Update(blobs, 50, 3, 10);
            }

            var buff = new Image<Gray, byte>(new Size(FRAME_WIDTH, FRAME_HEIGHT));

            foreach (var item in tracker)
            {
                buff.Draw(item.Value.BoundingBox, new Gray(255), 2);
                
            }

            frameShow.SetValue(new Bgr(0, 0, 255), buff);
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
        #endregion

    }
}
