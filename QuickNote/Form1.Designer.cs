﻿namespace QuickNote
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.書式EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMostTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.書式EToolStripMenuItem,
            this.バージョンVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 書式EToolStripMenuItem
            // 
            this.書式EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapWToolStripMenuItem,
            this.フォントEToolStripMenuItem,
            this.TopMostTToolStripMenuItem});
            this.書式EToolStripMenuItem.Name = "書式EToolStripMenuItem";
            this.書式EToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.書式EToolStripMenuItem.Text = "書式(&O)";
            // 
            // WordWrapWToolStripMenuItem
            // 
            this.WordWrapWToolStripMenuItem.Name = "WordWrapWToolStripMenuItem";
            this.WordWrapWToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.WordWrapWToolStripMenuItem.Text = "右端で折り返す(&W)";
            this.WordWrapWToolStripMenuItem.Click += new System.EventHandler(this.右端で折り返すWToolStripMenuItem_Click);
            // 
            // フォントEToolStripMenuItem
            // 
            this.フォントEToolStripMenuItem.Name = "フォントEToolStripMenuItem";
            this.フォントEToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.フォントEToolStripMenuItem.Text = "フォント(&F)...";
            this.フォントEToolStripMenuItem.Click += new System.EventHandler(this.フォントEToolStripMenuItem_Click);
            // 
            // TopMostTToolStripMenuItem
            // 
            this.TopMostTToolStripMenuItem.Name = "TopMostTToolStripMenuItem";
            this.TopMostTToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.TopMostTToolStripMenuItem.Text = "常に前面に(&T)";
            this.TopMostTToolStripMenuItem.Click += new System.EventHandler(this.常に前面にTToolStripMenuItem_Click);
            // 
            // バージョンVToolStripMenuItem
            // 
            this.バージョンVToolStripMenuItem.Name = "バージョンVToolStripMenuItem";
            this.バージョンVToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.バージョンVToolStripMenuItem.Text = "バージョン(&V)";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(635, 332);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem バージョンVToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 書式EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントEToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem WordWrapWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TopMostTToolStripMenuItem;
    }
}

