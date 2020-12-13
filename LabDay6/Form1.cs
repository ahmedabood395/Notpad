using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDay6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string path { get; set; }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb_txt.SaveFile(saveFileDialog1.FileName);
                rtb_txt.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb_txt.LoadFile(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_txt.Clear();
            path = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                rtb_txt.SaveFile(path);
                rtb_txt.Clear();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb_txt.SaveFile(saveFileDialog1.FileName);
                    rtb_txt.Clear();
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (rtb_txt.SelectedText == "")
                {
                    rtb_txt.Font = fontDialog1.Font;
                }
                else
                    rtb_txt.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (rtb_txt.SelectedText == "")
                {
                    rtb_txt.ForeColor = colorDialog1.Color;
                }
                else
                    rtb_txt.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
