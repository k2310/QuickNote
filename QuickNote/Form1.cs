using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void フォントEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                textBox1.Font = fontDialog1.Font;

            }

        }

        private void 右端で折り返すWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = !(textBox1.WordWrap);
        }

    }
}
