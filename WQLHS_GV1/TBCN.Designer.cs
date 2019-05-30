namespace WQLHS_GV1
{
    partial class TBCN
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbMaNH = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.qLHS_GV1DataSet10 = new WQLHS_GV1.QLHS_GV1DataSet10();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet10TableAdapters.NAMHOCTableAdapter();
            this.btnHT = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 148);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1237, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbbMaNH
            // 
            this.cbbMaNH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nAMHOCBindingSource, "MaNH", true));
            this.cbbMaNH.DataSource = this.nAMHOCBindingSource;
            this.cbbMaNH.DisplayMember = "MaNH";
            this.cbbMaNH.FormattingEnabled = true;
            this.cbbMaNH.ItemHeight = 23;
            this.cbbMaNH.Location = new System.Drawing.Point(330, 84);
            this.cbbMaNH.Name = "cbbMaNH";
            this.cbbMaNH.Size = new System.Drawing.Size(121, 29);
            this.cbbMaNH.TabIndex = 1;
            this.cbbMaNH.ValueMember = "MaNH";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(203, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Thông tin năm";
            // 
            // qLHS_GV1DataSet10
            // 
            this.qLHS_GV1DataSet10.DataSetName = "QLHS_GV1DataSet10";
            this.qLHS_GV1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHS_GV1DataSet10;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btnHT
            // 
            this.btnHT.Location = new System.Drawing.Point(546, 84);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(75, 37);
            this.btnHT.TabIndex = 3;
            this.btnHT.Text = "Hiển thị";
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // TBCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 540);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbMaNH);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TBCN";
            this.Text = "TBCN";
            this.Load += new System.EventHandler(this.TBCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroComboBox cbbMaNH;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private QLHS_GV1DataSet10 qLHS_GV1DataSet10;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHS_GV1DataSet10TableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private MetroFramework.Controls.MetroButton btnHT;
    }
}