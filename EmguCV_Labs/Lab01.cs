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
    public partial class Lab01 : Form
    {
        private static Lab01 _instance;
        public static Lab01 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab01();
                }
                return _instance;
            }
        }

        private Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }
    }
}
