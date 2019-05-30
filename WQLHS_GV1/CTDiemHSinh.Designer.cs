namespace WQLHS_GV1
{
    partial class CTDiemHSinh
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
            this.components = new System.ComponentModel.Container();
            this.cbbMaNH = new MetroFramework.Controls.MetroComboBox();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet10 = new WQLHS_GV1.QLHS_GV1DataSet10();
            this.btnHienThi = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSGV1DataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet10TableAdapters.NAMHOCTableAdapter();
            this.hOCKYTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet10TableAdapters.HOCKYTableAdapter();
            this.qLHS_GV1DataSet11 = new WQLHS_GV1.QLHS_GV1DataSet11();
            this.qLHSGV1DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet10TableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet10TableAdapters.MONHOCTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txbMaHK = new MetroFramework.Controls.MetroTextBox();
            this.txbMaLop = new MetroFramework.Controls.MetroTextBox();
            this.txbTenMH = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSGV1DataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSGV1DataSet11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaNH
            // 
            this.cbbMaNH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nAMHOCBindingSource, "MaNH", true));
            this.cbbMaNH.DataSource = this.nAMHOCBindingSource;
            this.cbbMaNH.DisplayMember = "MaNH";
            this.cbbMaNH.FormattingEnabled = true;
            this.cbbMaNH.ItemHeight = 23;
            this.cbbMaNH.Location = new System.Drawing.Point(58, 137);
            this.cbbMaNH.Name = "cbbMaNH";
            this.cbbMaNH.Size = new System.Drawing.Size(121, 29);
            this.cbbMaNH.TabIndex = 25;
            this.cbbMaNH.ValueMember = "MaNH";
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHS_GV1DataSet10;
            // 
            // qLHS_GV1DataSet10
            // 
            this.qLHS_GV1DataSet10.DataSetName = "QLHS_GV1DataSet10";
            this.qLHS_GV1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(1132, 107);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 51);
            this.btnHienThi.TabIndex = 21;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(360, 107);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Mã học kì";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(611, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Mã lớp";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(919, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Tên môn học";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Chọn thông tin cần tìm: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Mã năm học";
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.qLHS_GV1DataSet10;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLHSGV1DataSet10BindingSource;
            // 
            // qLHSGV1DataSet10BindingSource
            // 
            this.qLHSGV1DataSet10BindingSource.DataSource = this.qLHS_GV1DataSet10;
            this.qLHSGV1DataSet10BindingSource.Position = 0;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLHSGV1DataSet10BindingSource;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // qLHS_GV1DataSet11
            // 
            this.qLHS_GV1DataSet11.DataSetName = "QLHS_GV1DataSet11";
            this.qLHS_GV1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHSGV1DataSet11BindingSource
            // 
            this.qLHSGV1DataSet11BindingSource.DataSource = this.qLHS_GV1DataSet11;
            this.qLHSGV1DataSet11BindingSource.Position = 0;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(32, 210);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1228, 326);
            this.reportViewer1.TabIndex = 29;
            // 
            // txbMaHK
            // 
            this.txbMaHK.Location = new System.Drawing.Point(360, 143);
            this.txbMaHK.Name = "txbMaHK";
            this.txbMaHK.Size = new System.Drawing.Size(75, 23);
            this.txbMaHK.TabIndex = 30;
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(611, 143);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(75, 23);
            this.txbMaLop.TabIndex = 31;
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(919, 143);
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(75, 23);
            this.txbTenMH.TabIndex = 32;
            // 
            // CTDiemHSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 527);
            this.Controls.Add(this.txbTenMH);
            this.Controls.Add(this.txbMaLop);
            this.Controls.Add(this.txbMaHK);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbbMaNH);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CTDiemHSinh";
            this.Text = "CTDiemHSinh";
            this.Load += new System.EventHandler(this.CTDiemHSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSGV1DataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSGV1DataSet11BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbbMaNH;
        private MetroFramework.Controls.MetroButton btnHienThi;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private QLHS_GV1DataSet10 qLHS_GV1DataSet10;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHS_GV1DataSet10TableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QLHS_GV1DataSet10TableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private System.Windows.Forms.BindingSource qLHSGV1DataSet10BindingSource;
        private QLHS_GV1DataSet11 qLHS_GV1DataSet11;
        private System.Windows.Forms.BindingSource qLHSGV1DataSet11BindingSource;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLHS_GV1DataSet10TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLHS_GV1DataSet10TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroTextBox txbMaHK;
        private MetroFramework.Controls.MetroTextBox txbMaLop;
        private MetroFramework.Controls.MetroTextBox txbTenMH;
    }
}