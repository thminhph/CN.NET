namespace DoAn.NET1
{
    partial class frmBangVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangVP));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaVP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDungVP = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.stbnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.stbnCapNhap = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSV = new System.Windows.Forms.ComboBox();
            this.txtMaHP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungVP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 323);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1254, 625);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView1.OptionsFind.FindDelay = 500;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Nội Dung TÌm Kiếm";
            this.gridView1.OptionsFind.ShowClearButton = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.txtMaHP);
            this.groupControl1.Controls.Add(this.txtMaSV);
            this.groupControl1.Controls.Add(this.txtMaVP);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtNoiDungVP);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.LabelControl5);
            this.groupControl1.Controls.Add(this.LabelControl4);
            this.groupControl1.Controls.Add(this.LabelControl3);
            this.groupControl1.Controls.Add(this.LabelControl2);
            this.groupControl1.Controls.Add(this.LabelControl1);
            this.groupControl1.Controls.Add(this.TextEdit4);
            this.groupControl1.Location = new System.Drawing.Point(211, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(613, 270);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Thông Tin ";
            // 
            // txtMaVP
            // 
            this.txtMaVP.Location = new System.Drawing.Point(267, 56);
            this.txtMaVP.Name = "txtMaVP";
            this.txtMaVP.Size = new System.Drawing.Size(234, 26);
            this.txtMaVP.TabIndex = 93;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(52, 59);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 19);
            this.labelControl10.TabIndex = 92;
            this.labelControl10.Text = "Mã Vi Phạm";
            // 
            // txtNoiDungVP
            // 
            this.txtNoiDungVP.Location = new System.Drawing.Point(267, 109);
            this.txtNoiDungVP.Name = "txtNoiDungVP";
            this.txtNoiDungVP.Size = new System.Drawing.Size(234, 26);
            this.txtNoiDungVP.TabIndex = 79;
            this.txtNoiDungVP.EditValueChanged += new System.EventHandler(this.txtNoiDungVP_EditValueChanged);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(178, -34);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(234, 26);
            this.textEdit3.TabIndex = 77;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(577, -27);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(42, 19);
            this.LabelControl5.TabIndex = 73;
            this.LabelControl5.Text = "maCV";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(52, 213);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(92, 19);
            this.LabelControl4.TabIndex = 72;
            this.LabelControl4.Text = "Mã Học Phần";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(52, 164);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(92, 19);
            this.LabelControl3.TabIndex = 71;
            this.LabelControl3.Text = "Mã Sinh Viên";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(52, 112);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(131, 19);
            this.LabelControl2.TabIndex = 70;
            this.LabelControl2.Text = "Nội Dung Vi Phạm";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(86, -31);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(46, 19);
            this.LabelControl1.TabIndex = 69;
            this.LabelControl1.Text = "Mã GV";
            // 
            // TextEdit4
            // 
            this.TextEdit4.Location = new System.Drawing.Point(639, -30);
            this.TextEdit4.Name = "TextEdit4";
            this.TextEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextEdit4.Size = new System.Drawing.Size(209, 26);
            this.TextEdit4.TabIndex = 82;
            // 
            // stbnThoat
            // 
            this.stbnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stbnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stbnThoat.ImageOptions.Image")));
            this.stbnThoat.Location = new System.Drawing.Point(947, 217);
            this.stbnThoat.Name = "stbnThoat";
            this.stbnThoat.Size = new System.Drawing.Size(112, 34);
            this.stbnThoat.TabIndex = 15;
            this.stbnThoat.Text = "Thoát";
            this.stbnThoat.Click += new System.EventHandler(this.stbnThoat_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnXoa.ImageOptions.Image")));
            this.sbtnXoa.Location = new System.Drawing.Point(947, 168);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.Size = new System.Drawing.Size(112, 34);
            this.sbtnXoa.TabIndex = 16;
            this.sbtnXoa.Text = "Xóa ";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // stbnCapNhap
            // 
            this.stbnCapNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stbnCapNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stbnCapNhap.ImageOptions.Image")));
            this.stbnCapNhap.Location = new System.Drawing.Point(947, 113);
            this.stbnCapNhap.Name = "stbnCapNhap";
            this.stbnCapNhap.Size = new System.Drawing.Size(112, 34);
            this.stbnCapNhap.TabIndex = 17;
            this.stbnCapNhap.Text = "Cập Nhập";
            this.stbnCapNhap.Click += new System.EventHandler(this.stbnCapNhap_Click);
            // 
            // sbtnThem
            // 
            this.sbtnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThem.ImageOptions.Image")));
            this.sbtnThem.Location = new System.Drawing.Point(947, 63);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.Size = new System.Drawing.Size(112, 34);
            this.sbtnThem.TabIndex = 18;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaSV.FormattingEnabled = true;
            this.txtMaSV.Location = new System.Drawing.Point(267, 161);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(234, 27);
            this.txtMaSV.TabIndex = 98;
            this.txtMaSV.SelectedIndexChanged += new System.EventHandler(this.txtMaSV_SelectedIndexChanged);
            // 
            // txtMaHP
            // 
            this.txtMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtMaHP.FormattingEnabled = true;
            this.txtMaHP.Location = new System.Drawing.Point(267, 223);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(234, 28);
            this.txtMaHP.TabIndex = 99;
            // 
            // frmBangVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 948);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.stbnThoat);
            this.Controls.Add(this.sbtnXoa);
            this.Controls.Add(this.stbnCapNhap);
            this.Controls.Add(this.sbtnThem);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBangVP";
            this.Text = "frmBangVP";
            this.Load += new System.EventHandler(this.frmBangVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungVP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        internal DevExpress.XtraEditors.TextEdit txtMaVP;
        internal DevExpress.XtraEditors.LabelControl labelControl10;
        internal DevExpress.XtraEditors.TextEdit txtNoiDungVP;
        internal DevExpress.XtraEditors.TextEdit textEdit3;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.ComboBoxEdit TextEdit4;
        private DevExpress.XtraEditors.SimpleButton stbnThoat;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton stbnCapNhap;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        public System.Windows.Forms.ComboBox txtMaSV;
        private System.Windows.Forms.ComboBox txtMaHP;
    }
}