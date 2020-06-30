using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새파일 두둥등장");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //종료
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 배고파ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배고파배고프다굿!";
            toolStripProgressBar1.Value = 10;
        }

        private void 음먹으면들어가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "그냥그렇누";
            toolStripProgressBar1.Value = 50;
        }

        private void 배불러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배배배배배불불불불러러러러러";
            toolStripProgressBar1.Value = 100;
        }
    }
}
