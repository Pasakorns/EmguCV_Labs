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

        public Lab02()
        {
            InitializeComponent();
        }
    }
}
