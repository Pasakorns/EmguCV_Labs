using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCV_Labs
{
    public partial class Lab04_sobel : Form
    {
        private static Lab04_sobel _instance;
        public static Lab04_sobel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab04_sobel();
                }
                return _instance;
            }
        }

        private int _apertureSize;

        public Lab04_sobel()
        {
            InitializeComponent();
        }

        private void Lab04_sobel_Load(object sender, EventArgs e)
        {
            _apertureSize = trbApertureSize.Value * 2 + 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trbXorder.Value >= _apertureSize)
            {
                trbXorder.Value = 1;
            }

            if (trbYorder.Value >= _apertureSize)
            {
                trbYorder.Value = 1;
            }

            lblXorder.Text = trbXorder.Value.ToString();
            lblYorder.Text = trbYorder.Value.ToString();
        }

        private void trbApertureSize_Scroll(object sender, EventArgs e)
        {
            _apertureSize = trbApertureSize.Value * 2 + 1;
            lblAperture.Text = _apertureSize.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab04.Instance.Sobel(trbXorder.Value, trbYorder.Value, _apertureSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trbXorder.Value = 1;
            trbYorder.Value = 1;
            trbApertureSize.Value = 2;

            lblXorder.Text = trbXorder.Value.ToString();
            lblYorder.Text = trbYorder.Value.ToString();
            _apertureSize = trbApertureSize.Value * 2 + 1;
            lblAperture.Text = _apertureSize.ToString();
        }

    }
}
