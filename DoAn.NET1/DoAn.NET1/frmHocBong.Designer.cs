namespace DoAn.NET1
{
    partial class frmHocBong
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvHocBong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocBong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(138, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(814, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH SINH VIÊN NHẬN HỌC BỔNG";
            // 
            // dgvHocBong
            // 
            this.dgvHocBong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocBong.Location = new System.Drawing.Point(0, 119);
            this.dgvHocBong.MainView = this.gridView1;
            this.dgvHocBong.Name = "dgvHocBong";
            this.dgvHocBong.Size = new System.Drawing.Size(1125, 681);
            this.dgvHocBong.TabIndex = 1;
            this.dgvHocBong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvHocBong.Click += new System.EventHandler(this.dgvHocBong_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvHocBong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView1.OptionsFind.FindDelay = 500;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Nội Dùng Tìm Kiếm";
            this.gridView1.OptionsFind.ShowClearButton = false;
            // 
            // frmHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 800);
            this.Controls.Add(this.dgvHocBong);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmHocBong";
            this.Text = "frmHocBong";
            this.Load += new System.EventHandler(this.frmHocBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocBong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvHocBong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}