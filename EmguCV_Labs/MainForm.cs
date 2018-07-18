using System;
using System.Windows.Forms;

namespace EmguCV_Labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01.Instance.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02.Instance.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab03.Instance.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab04.Instance.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab05.Instance.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab06.Instance.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab07.Instance.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lab08.Instance.ShowDialog();
        }
    }
}
