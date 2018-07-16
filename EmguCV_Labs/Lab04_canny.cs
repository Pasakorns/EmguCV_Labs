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
    public partial class Lab04_canny : Form
    {
        private static Lab04_canny _instance;
        public static Lab04_canny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab04_canny();
                }
                return _instance;
            }
        }

        private int _apertureSize;

        public Lab04_canny()
        {
            InitializeComponent();
        }

        private void Lab04_canny_Load(object sender, EventArgs e)
        {
            _apertureSize = trbApertureSize.Value * 2 + 1;
        }

        private void tbaThreshold1_Scroll(object sender, EventArgs e)
        {
            lblThreshold1.Text = tbaThreshold1.Value.ToString();
            lblThreshold2.Text = tbaThreshold2.Value.ToString();
            _apertureSize = trbApertureSize.Value * 2 + 1;
            lblApertureSize.Text = _apertureSize.ToString();
        }

        private void button1_Click(object sender, EventArgs e)  // Apply
        {
            Lab04.Instance.Canny(tbaThreshold1.Value, tbaThreshold2.Value, _apertureSize, rdoOn.Checked);
        }

        private void button2_Click(object sender, EventArgs e)  // Reset
        {
            tbaThreshold1.Value = 20;
            tbaThreshold2.Value = 50;
            trbApertureSize.Value = 1;
            _apertureSize = trbApertureSize.Value * 2 + 1;

            lblThreshold1.Text = tbaThreshold1.Value.ToString();
            lblThreshold2.Text = tbaThreshold2.Value.ToString();
            lblApertureSize.Text = _apertureSize.ToString();

            rdoOff.Checked = true;
        }
    }
}
