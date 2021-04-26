using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicEightBallApplication
{
    public partial class frmMagicEightBall : Form
    {
        Random rnd = new Random();

        public frmMagicEightBall()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            int number = rnd.Next(1, 15);

            switch (number)
            {
                case 1: bpDisplay.Image = Properties.Resources._1;
                    break;
                case 2:
                    bpDisplay.Image = Properties.Resources._2;
                    break;
                case 3:
                    bpDisplay.Image = Properties.Resources._3;
                    break;
                case 4:
                    bpDisplay.Image = Properties.Resources._4;
                    break;
                case 5:
                    bpDisplay.Image = Properties.Resources._5;
                    break;
                case 6:
                    bpDisplay.Image = Properties.Resources._6;
                    break;
                case 7:
                    bpDisplay.Image = Properties.Resources._7;
                    break;
                case 8:
                    bpDisplay.Image = Properties.Resources._8;
                    break;
                case 9:
                    bpDisplay.Image = Properties.Resources._9;
                    break;
                case 10:
                    bpDisplay.Image = Properties.Resources._10;
                    break;
                case 11:
                    bpDisplay.Image = Properties.Resources._11;
                    break;
                case 12:
                    bpDisplay.Image = Properties.Resources._12;
                    break;
                case 13:
                    bpDisplay.Image = Properties.Resources._13;
                    break;
                case 14:
                    bpDisplay.Image = Properties.Resources._14;
                    break;
                case 15:
                    bpDisplay.Image = Properties.Resources._15;
                    break;
            }
        }
    }
}
