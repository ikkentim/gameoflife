using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOfLife.Clear();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOfLife.Running = !gameOfLife.Running;
            startToolStripMenuItem.Text = gameOfLife.Running
                ? "Stop"
                : "Start";
        }

        private void msToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 25;
        }

        private void msToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 50;
        }

        private void msToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 100;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 250;
        }

        private void msToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 500;
        }

        private void msToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 750;
        }

        private void msToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 1000;
        }

        private void msToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            gameOfLife.Interval = 2500;
        }
    }
}
