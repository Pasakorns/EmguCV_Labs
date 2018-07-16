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
    public partial class Lab04_laplaciant : Form
    {
        private static Lab04_laplaciant _instance;
        public static Lab04_laplaciant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab04_laplaciant();
                }
                return _instance;
            }
        }

        public Lab04_laplaciant()
        {
            InitializeComponent();
        }

        private void Lab04_laplaciant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab04.Instance.Laplacian((int)nudApertureSize.Value);
        }
    }
}
