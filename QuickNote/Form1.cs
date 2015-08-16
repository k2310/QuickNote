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
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            
            textBox1.WordWrap = !(textBox1.WordWrap);
            item.Checked = textBox1.WordWrap;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void saveSettings()
        {
           // Font
            Properties.Settings.Default.Font = textBox1.Font;

            // Window State & Size
           if (WindowState == FormWindowState.Normal)
               Properties.Settings.Default.Bounds = Bounds;
           else
               Properties.Settings.Default.Bounds = RestoreBounds;
           Properties.Settings.Default.WindowState = WindowState;
           
           // WordWrap
           Properties.Settings.Default.WordWrap = textBox1.WordWrap;
           
            // Contents
           saveContents();

           Properties.Settings.Default.Save();
        }

        private void saveContents()
        {
            Properties.Settings.Default.Contents = textBox1.Text;
        }

        private void loadSettings()
        {
            // Window State & Size
            WindowState = Properties.Settings.Default.WindowState;
            Bounds = Properties.Settings.Default.Bounds;

            // Font
            textBox1.Font = Properties.Settings.Default.Font;

            // WordWrap
            textBox1.WordWrap = Properties.Settings.Default.WordWrap;
            ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items.Find("WordWrapWToolStripMenuItem", true)[0];
            item.Checked = textBox1.WordWrap;

            // Contents
            textBox1.Text = Properties.Settings.Default.Contents;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void 常に前面にTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.TopMost = !this.TopMost;
            item.Checked = this.TopMost;

        }


    }
}
