namespace DoAn.NET1
{
    partial class frmChucNangKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucNangKhoa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stbnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.stbnCapNhap = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.txtMaKhoa);
            this.groupControl1.Controls.Add(this.stbnThoat);
            this.groupControl1.Controls.Add(this.sbtnXoa);
            this.groupControl1.Controls.Add(this.stbnCapNhap);
            this.groupControl1.Controls.Add(this.sbtnThem);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtTenKhoa);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.LabelControl5);
            this.groupControl1.Controls.Add(this.LabelControl2);
            this.groupControl1.Controls.Add(this.LabelControl1);
            this.groupControl1.Controls.Add(this.TextEdit4);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(815, 237);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Nhập Thông Tin Khoa";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // stbnThoat
            // 
            this.stbnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stbnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stbnThoat.ImageOptions.Image")));
            this.stbnThoat.Location = new System.Drawing.Point(636, 146);
            this.stbnThoat.Name = "stbnThoat";
            this.stbnThoat.Size = new System.Drawing.Size(112, 34);
            this.stbnThoat.TabIndex = 25;
            this.stbnThoat.Text = "Thoát";
            this.stbnThoat.Click += new System.EventHandler(this.stbnThoat_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnXoa.ImageOptions.Image")));
            this.sbtnXoa.Location = new System.Drawing.Point(457, 146);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.Size = new System.Drawing.Size(112, 34);
            this.sbtnXoa.TabIndex = 26;
            this.sbtnXoa.Text = "Xóa ";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // stbnCapNhap
            // 
            this.stbnCapNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stbnCapNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stbnCapNhap.ImageOptions.Image")));
            this.stbnCapNhap.Location = new System.Drawing.Point(636, 67);
            this.stbnCapNhap.Name = "stbnCapNhap";
            this.stbnCapNhap.Size = new System.Drawing.Size(112, 34);
            this.stbnCapNhap.TabIndex = 27;
            this.stbnCapNhap.Text = "Cập Nhập";
            this.stbnCapNhap.Click += new System.EventHandler(this.stbnCapNhap_Click);
            // 
            // sbtnThem
            // 
            this.sbtnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThem.ImageOptions.Image")));
            this.sbtnThem.Location = new System.Drawing.Point(457, 67);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.Size = new System.Drawing.Size(112, 34);
            this.sbtnThem.TabIndex = 28;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Location = new System.Drawing.Point(37, 96);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 19);
            this.labelControl10.TabIndex = 92;
            this.labelControl10.Text = "Mã Khoa";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKhoa.Location = new System.Drawing.Point(142, 135);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(234, 26);
            this.txtTenKhoa.TabIndex = 79;
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit3.Location = new System.Drawing.Point(178, -34);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(234, 26);
            this.textEdit3.TabIndex = 77;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelControl5.Location = new System.Drawing.Point(577, -27);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(42, 19);
            this.LabelControl5.TabIndex = 73;
            this.LabelControl5.Text = "maCV";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelControl2.Location = new System.Drawing.Point(37, 138);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(67, 19);
            this.LabelControl2.TabIndex = 70;
            this.LabelControl2.Text = "Tên Khoa";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelControl1.Location = new System.Drawing.Point(86, -31);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(46, 19);
            this.LabelControl1.TabIndex = 69;
            this.LabelControl1.Text = "Mã GV";
            // 
            // TextEdit4
            // 
            this.TextEdit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextEdit4.Location = new System.Drawing.Point(639, -30);
            this.TextEdit4.Name = "TextEdit4";
            this.TextEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextEdit4.Size = new System.Drawing.Size(209, 26);
            this.TextEdit4.TabIndex = 82;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKhoa.Location = new System.Drawing.Point(142, 89);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(234, 26);
            this.txtMaKhoa.TabIndex = 94;
            // 
            // frmChucNangKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 278);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChucNangKhoa";
            this.Text = "frmChucNangKhoa";
            this.Load += new System.EventHandler(this.frmChucNangKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton stbnThoat;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton stbnCapNhap;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        internal DevExpress.XtraEditors.LabelControl labelControl10;
        internal DevExpress.XtraEditors.TextEdit txtTenKhoa;
        internal DevExpress.XtraEditors.TextEdit textEdit3;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.ComboBoxEdit TextEdit4;
        internal DevExpress.XtraEditors.TextEdit txtMaKhoa;
    }
}