using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UiMiniProgect
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRes1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRes1.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRes.Visible = false;
            btnRes1.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (PanMinu.Width == 249)
            {
                PanMinu.Width = 66;
            }
            else
                PanMinu.Width = 249;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
