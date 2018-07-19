using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;

namespace EmguCV_Labs
{
    public partial class Lab09 : Form
    {
        private static Lab09 _instance;
        public static Lab09 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab09();
                }
                return _instance;
            }
        }

        private const int FRAME_WIDTH = 320;
        private const int FRAME_HEIGHT = 240;

        Image<Bgr, byte> sourceImg;
        Image<Gray, byte> grayImg;

        CvBlobs foundBlobs;
       
        private Lab09()
        {
            InitializeComponent();
        }

        private void Lab09_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Emgu.CV.CvEnum.ThresholdType)))
            {
                cboThresType.Items.Add(item);
            }

            cboThresType.SelectedIndex = 0;
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImg = new Image<Bgr, byte>(ofd.FileName).Resize(FRAME_WIDTH, FRAME_HEIGHT, Emgu.CV.CvEnum.Inter.Linear);
                    var buff = sourceImg.Mat;

                    imbInput.Image = buff;
                    imbOutput.Image =  ImageFillter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                foundBlobs = BlobDetect();

                #region Draw all blobs
                var buff = new Image<Bgr, byte>(sourceImg.Bitmap);
                foreach (var item in foundBlobs)
                {
                    buff.Draw(rect: item.Value.BoundingBox,
                                color: new Bgr(0,0,255), 
                                thickness: 2);
                    buff.Draw(cross: new Cross2DF(item.Value.Centroid, 10, 10),
                                color: new Bgr(0,0,255),
                                thickness: 1);
                }
                
                imbInput.Image = buff;
                buff.Dispose();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trbThreshold_Scroll(object sender, EventArgs e)
        {
            try
            {
                grayImg = ImageFillter();
                imbOutput.Image = grayImg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboThresType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                grayImg = ImageFillter();
                imbOutput.Image = grayImg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBlobId_SelectedIndexChanged(object sender, EventArgs e)
        {
            BlobResultUpdate(foundBlobs);
        }
        /// <summary>
        /// Fillering image
        /// </summary>
        /// <returns>Gray image</returns>
        private Image<Gray, Byte> ImageFillter()
        {
            if (sourceImg != null)
            {
                Image<Gray, Byte> buff = sourceImg.Convert<Gray, Byte>();
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
        /// <summary>
        /// Detect all blob
        /// </summary>
        /// <returns>Collection of blob</returns>
        private CvBlobs BlobDetect()
        {
            var buff = ImageFillter();
            CvBlobDetector detector = new CvBlobDetector();
            CvBlobs blobs = new CvBlobs();

            uint result = detector.Detect(buff, blobs);

            if (blobs.Count > 0 && !blobs.Equals(null))
            {
                cboBlobId.Items.Clear();
                foreach (var item in blobs)
                {
                    cboBlobId.Items.Add(item);
                }
                lblFoundNo.Text = blobs.Count.ToString();
            }

            return blobs;
        }
        /// <summary>
        /// Draw selected blob and show blob datas
        /// </summary>
        /// <param name="blobs">Detected blobs</param>
        private void BlobResultUpdate(CvBlobs blobs)
        {
            if (cboBlobId.SelectedItem != null)
            {
                KeyValuePair<uint, CvBlob> selectedBlob = (KeyValuePair<uint, CvBlob>)cboBlobId.SelectedItem;

                lblArea.Text = selectedBlob.Value.Area.ToString();
                lblCtX.Text = selectedBlob.Value.Centroid.X.ToString();
                lblCtY.Text = selectedBlob.Value.Centroid.Y.ToString();

                var buff = new Image<Bgr, byte>(sourceImg.Bitmap);
                buff.Draw(rect: selectedBlob.Value.BoundingBox,
                            color: new Bgr(255,255,0),
                            thickness: 2);
                buff.Draw(cross: new Cross2DF(selectedBlob.Value.Centroid, 10, 10),
                            color: new Bgr(255, 255, 0),
                            thickness: 1);
                imbInput.Image = buff;
                buff.Dispose();
            }
        }
    }
}
