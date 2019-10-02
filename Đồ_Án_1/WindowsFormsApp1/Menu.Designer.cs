﻿namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thaoTacVoiSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachCacCuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacLoaiSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTacVoiSachToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thaoTacVoiSachToolStripMenuItem
            // 
            this.thaoTacVoiSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachCacCuonSachToolStripMenuItem,
            this.cacLoaiSachToolStripMenuItem});
            this.thaoTacVoiSachToolStripMenuItem.Name = "thaoTacVoiSachToolStripMenuItem";
            this.thaoTacVoiSachToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.thaoTacVoiSachToolStripMenuItem.Text = "Thao tac voi Sach";
            // 
            // danhSachCacCuonSachToolStripMenuItem
            // 
            this.danhSachCacCuonSachToolStripMenuItem.Name = "danhSachCacCuonSachToolStripMenuItem";
            this.danhSachCacCuonSachToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.danhSachCacCuonSachToolStripMenuItem.Text = "Danh sach cac cuon sach";
            this.danhSachCacCuonSachToolStripMenuItem.Click += new System.EventHandler(this.danhSachCacCuonSachToolStripMenuItem_Click);
            // 
            // cacLoaiSachToolStripMenuItem
            // 
            this.cacLoaiSachToolStripMenuItem.Name = "cacLoaiSachToolStripMenuItem";
            this.cacLoaiSachToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.cacLoaiSachToolStripMenuItem.Text = "Cac loai sach";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thaoTacVoiSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachCacCuonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacLoaiSachToolStripMenuItem;
    }
}