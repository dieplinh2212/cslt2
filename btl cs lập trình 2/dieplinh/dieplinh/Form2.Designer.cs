
namespace dieplinh
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHosomuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHosotra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTongTienThuDuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachchuatra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachtheothemuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimthuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.chuongtrinhquanly = new System.Windows.Forms.Label();
            this.Hieusach = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuHoso,
            this.mnuBaocao,
            this.mnuTimkiem,
            this.mnuThoat});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuthu,
            this.mnuSach,
            this.mnuThemuon,
            this.mnuNXB});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            resources.ApplyResources(this.mnuDanhmuc, "mnuDanhmuc");
            // 
            // mnuThuthu
            // 
            this.mnuThuthu.Name = "mnuThuthu";
            resources.ApplyResources(this.mnuThuthu, "mnuThuthu");
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            resources.ApplyResources(this.mnuSach, "mnuSach");
            // 
            // mnuThemuon
            // 
            this.mnuThemuon.Name = "mnuThemuon";
            resources.ApplyResources(this.mnuThemuon, "mnuThemuon");
            // 
            // mnuNXB
            // 
            this.mnuNXB.Name = "mnuNXB";
            resources.ApplyResources(this.mnuNXB, "mnuNXB");
            // 
            // mnuHoso
            // 
            this.mnuHoso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHosomuon,
            this.mnuHosotra});
            this.mnuHoso.Name = "mnuHoso";
            resources.ApplyResources(this.mnuHoso, "mnuHoso");
            // 
            // mnuHosomuon
            // 
            this.mnuHosomuon.Name = "mnuHosomuon";
            resources.ApplyResources(this.mnuHosomuon, "mnuHosomuon");
            // 
            // mnuHosotra
            // 
            this.mnuHosotra.Name = "mnuHosotra";
            resources.ApplyResources(this.mnuHosotra, "mnuHosotra");
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTongTienThuDuoc,
            this.mnuDanhsachchuatra,
            this.mnuDanhsachtheothemuon});
            this.mnuBaocao.Name = "mnuBaocao";
            resources.ApplyResources(this.mnuBaocao, "mnuBaocao");
            // 
            // mnuTongTienThuDuoc
            // 
            this.mnuTongTienThuDuoc.Name = "mnuTongTienThuDuoc";
            resources.ApplyResources(this.mnuTongTienThuDuoc, "mnuTongTienThuDuoc");
            // 
            // mnuDanhsachchuatra
            // 
            this.mnuDanhsachchuatra.Name = "mnuDanhsachchuatra";
            resources.ApplyResources(this.mnuDanhsachchuatra, "mnuDanhsachchuatra");
            // 
            // mnuDanhsachtheothemuon
            // 
            this.mnuDanhsachtheothemuon.Name = "mnuDanhsachtheothemuon";
            resources.ApplyResources(this.mnuDanhsachtheothemuon, "mnuDanhsachtheothemuon");
            this.mnuDanhsachtheothemuon.Click += new System.EventHandler(this.danhSáchHồSơMượnTheoThẻMượnToolStripMenuItem_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimsach,
            this.mnuTimthuthu});
            this.mnuTimkiem.Name = "mnuTimkiem";
            resources.ApplyResources(this.mnuTimkiem, "mnuTimkiem");
            // 
            // mnuTimsach
            // 
            this.mnuTimsach.Name = "mnuTimsach";
            resources.ApplyResources(this.mnuTimsach, "mnuTimsach");
            // 
            // mnuTimthuthu
            // 
            this.mnuTimthuthu.Name = "mnuTimthuthu";
            resources.ApplyResources(this.mnuTimthuthu, "mnuTimthuthu");
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            resources.ApplyResources(this.mnuThoat, "mnuThoat");
            // 
            // chuongtrinhquanly
            // 
            resources.ApplyResources(this.chuongtrinhquanly, "chuongtrinhquanly");
            this.chuongtrinhquanly.BackColor = System.Drawing.Color.PapayaWhip;
            this.chuongtrinhquanly.ForeColor = System.Drawing.Color.Black;
            this.chuongtrinhquanly.Name = "chuongtrinhquanly";
            this.chuongtrinhquanly.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hieusach
            // 
            resources.ApplyResources(this.Hieusach, "Hieusach");
            this.Hieusach.BackColor = System.Drawing.Color.PapayaWhip;
            this.Hieusach.Name = "Hieusach";
            // 
            // formMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dieplinh.Properties.Resources.bg1;
            this.Controls.Add(this.Hieusach);
            this.Controls.Add(this.chuongtrinhquanly);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThuthu;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuThemuon;
        private System.Windows.Forms.ToolStripMenuItem mnuNXB;
        private System.Windows.Forms.ToolStripMenuItem mnuHoso;
        private System.Windows.Forms.ToolStripMenuItem mnuHosomuon;
        private System.Windows.Forms.ToolStripMenuItem mnuHosotra;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuTongTienThuDuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachchuatra;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachtheothemuon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimsach;
        private System.Windows.Forms.ToolStripMenuItem mnuTimthuthu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label chuongtrinhquanly;
        private System.Windows.Forms.Label Hieusach;
    }
}