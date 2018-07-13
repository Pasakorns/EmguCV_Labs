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
    public partial class Lab03 : Form
    {
        private static Lab03 _instance;
        public static Lab03 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lab03();
                }
                return _instance;
            }
        }

        public Lab03()
        {
            InitializeComponent();
        }
    }
}
