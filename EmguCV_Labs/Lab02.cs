using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace EmguCV_Labs
{
    public partial class Lab02 : Form
    {
        private static Lab02 _instance;
        public static Lab02 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab02();
                }
                return _instance;
            }
        }

        Image<Bgr, Byte> inputImg;
        Image<Gray, Byte> grayImg;
        Image<Gray, Byte> binImg;
        int th = 100;

        private Lab02()
        {
            InitializeComponent();
        }

        private void Lab02_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(ThresholdType)))
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(AdaptiveThresholdType)))
            {
                cboAdapType.Items.Add(item);
            }
            cboAdapType.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputImg = new Image<Bgr, byte>(ofd.FileName);
                grayImg = inputImg.Convert<Gray, Byte>();
                binImg = new Image<Gray, byte>(grayImg.Width, grayImg.Height, new Gray(0));

                pboColor.Image = inputImg.ToBitmap(pboColor.Width, pboColor.Height);
                pboGray.Image = binImg.ToBitmap(pboGray.Width, pboGray.Height);

                ImageThreshold();
            }
        }

        private void btnSample1_Click(object sender, EventArgs e)
        {
            inputImg = new Image<Bgr, byte>(Properties.Resources.gray_linear);
            grayImg = inputImg.Convert<Gray, Byte>();
            binImg = new Image<Gray, byte>(grayImg.Width, grayImg.Height, new Gray(0));

            pboColor.Image = inputImg.ToBitmap(pboColor.Width, pboColor.Height);
            pboGray.Image = binImg.ToBitmap(pboGray.Width, pboGray.Height);

            ImageThreshold();
        }

        private void btnSample2_Click(object sender, EventArgs e)
        {
            inputImg = new Image<Bgr, byte>(Properties.Resources.gray_circle);
            grayImg = inputImg.Convert<Gray, Byte>();
            binImg = new Image<Gray, byte>(grayImg.Width, grayImg.Height, new Gray(0));

            pboColor.Image = inputImg.ToBitmap(pboColor.Width, pboColor.Height);
            pboGray.Image = binImg.ToBitmap(pboGray.Width, pboGray.Height);

            ImageThreshold();
        }

        private void tbaThreshold_Scroll(object sender, EventArgs e)
        {
            th = tbaThreshold.Value;
            label1.Text = th.ToString();

            ImageThreshold();
        }

        private void cboAdapEn_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAdapEn.Checked)
            {
                tbrMSize.Enabled = true;
                tbrMValue.Enabled = true;
                cboAdapType.Enabled = true;
                tbaThreshold.Enabled = false;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                tbrMSize.Enabled = false;
                tbrMValue.Enabled = false;
                cboAdapType.Enabled = false;
                tbaThreshold.Enabled = true;
            }
        }

        private void tbrMSize_Scroll(object sender, EventArgs e)
        {
            Int32 mSize = Convert.ToInt32((2 * tbrMSize.Value) + 1);
            double mValue = tbrMValue.Value;
            lblMSize.Text = mSize.ToString();
            lblMValue.Text = mValue.ToString();
            ImageThreshold();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageThreshold();
        }

        private void ImageThreshold()
        {
            if (grayImg != null)
            {
                try
                {
                    if (cboAdapEn.Checked)
                    {
                        CvInvoke.AdaptiveThreshold(grayImg, binImg, 255, (AdaptiveThresholdType)cboAdapType.SelectedItem,
                                                                      (ThresholdType)comboBox1.SelectedItem,
                                                                      Convert.ToInt32((2 * tbrMSize.Value) + 1),//require only Odd number and > 0
                                                                      tbrMValue.Value);
                    }
                    else
                    {
                        CvInvoke.Threshold(grayImg, binImg, th, 255, (Emgu.CV.CvEnum.ThresholdType)comboBox1.SelectedItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                pboGray.Image = binImg.ToBitmap(pboGray.Width, pboGray.Height);
            }
        }

    }
}
