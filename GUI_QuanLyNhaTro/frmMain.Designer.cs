namespace GUI_QuanLyNhaTro
{
    partial class frmMain
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
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chủSởHữuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngTrọToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.danhMụcToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(85, 23);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chủSởHữuToolStripMenuItem,
            this.phòngTrọToolStripMenuItem,
            this.kháchThuêToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem,
            this.hóaĐơnThángToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // chủSởHữuToolStripMenuItem
            // 
            this.chủSởHữuToolStripMenuItem.Name = "chủSởHữuToolStripMenuItem";
            this.chủSởHữuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chủSởHữuToolStripMenuItem.Text = "Chủ sở hữu";
            // 
            // phòngTrọToolStripMenuItem
            // 
            this.phòngTrọToolStripMenuItem.Name = "phòngTrọToolStripMenuItem";
            this.phòngTrọToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phòngTrọToolStripMenuItem.Text = "Phòng trọ";
            // 
            // kháchThuêToolStripMenuItem
            // 
            this.kháchThuêToolStripMenuItem.Name = "kháchThuêToolStripMenuItem";
            this.kháchThuêToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchThuêToolStripMenuItem.Text = "Khách thuê";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp đồng ";
            // 
            // hóaĐơnThángToolStripMenuItem
            // 
            this.hóaĐơnThángToolStripMenuItem.Name = "hóaĐơnThángToolStripMenuItem";
            this.hóaĐơnThángToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnThángToolStripMenuItem.Text = "Hóa đơn tháng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Trang chu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chủSởHữuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngTrọToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
    }
}