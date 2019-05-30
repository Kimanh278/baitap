namespace WQLHS_GV1
{
    partial class NamHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbTenNH = new MetroFramework.Controls.MetroLabel();
            this.txbMaNH = new MetroFramework.Controls.MetroTextBox();
            this.txbTenNH1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbTK = new MetroFramework.Controls.MetroTextBox();
            this.btnTK = new MetroFramework.Controls.MetroButton();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.mttSua = new MetroFramework.Controls.MetroTile();
            this.mttXoa = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet = new WQLHS_GV1.QLHS_GV1DataSet();
            this.nAMHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.NAMHOCTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã năm học";
            // 
            // txbTenNH
            // 
            this.txbTenNH.AutoSize = true;
            this.txbTenNH.Location = new System.Drawing.Point(31, 90);
            this.txbTenNH.Name = "txbTenNH";
            this.txbTenNH.Size = new System.Drawing.Size(83, 19);
            this.txbTenNH.TabIndex = 1;
            this.txbTenNH.Text = "Tên năm học";
            // 
            // txbMaNH
            // 
            this.txbMaNH.Location = new System.Drawing.Point(164, 38);
            this.txbMaNH.Name = "txbMaNH";
            this.txbMaNH.Size = new System.Drawing.Size(132, 23);
            this.txbMaNH.TabIndex = 2;
            // 
            // txbTenNH1
            // 
            this.txbTenNH1.Location = new System.Drawing.Point(164, 85);
            this.txbTenNH1.Name = "txbTenNH1";
            this.txbTenNH1.Size = new System.Drawing.Size(132, 23);
            this.txbTenNH1.TabIndex = 3;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 43);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 42;
            this.metroLabel6.Text = "Nhập thông tin cần tìm";
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(169, 39);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(224, 23);
            this.txbTK.TabIndex = 43;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(481, 43);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 44;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(54, 177);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(118, 105);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 45;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.reload;
            this.mttReload.UseTileImage = true;
            this.mttReload.Click += new System.EventHandler(this.mttReload_Click);
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(263, 177);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 46;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.add;
            this.mttThem.UseTileImage = true;
            this.mttThem.Click += new System.EventHandler(this.mttThem_Click);
            // 
            // mttSua
            // 
            this.mttSua.Location = new System.Drawing.Point(54, 288);
            this.mttSua.Name = "mttSua";
            this.mttSua.Size = new System.Drawing.Size(104, 105);
            this.mttSua.Style = MetroFramework.MetroColorStyle.White;
            this.mttSua.TabIndex = 47;
            this.mttSua.TileImage = global::WQLHS_GV1.Properties.Resources.edit;
            this.mttSua.UseTileImage = true;
            this.mttSua.Click += new System.EventHandler(this.mttSua_Click);
            // 
            // mttXoa
            // 
            this.mttXoa.Location = new System.Drawing.Point(260, 288);
            this.mttXoa.Name = "mttXoa";
            this.mttXoa.Size = new System.Drawing.Size(117, 105);
            this.mttXoa.Style = MetroFramework.MetroColorStyle.White;
            this.mttXoa.TabIndex = 48;
            this.mttXoa.TileImage = global::WQLHS_GV1.Properties.Resources.delete;
            this.mttXoa.UseTileImage = true;
            this.mttXoa.Click += new System.EventHandler(this.mttXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNHDataGridViewTextBoxColumn,
            this.tenNHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nAMHOCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 294);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // maNHDataGridViewTextBoxColumn
            // 
            this.maNHDataGridViewTextBoxColumn.DataPropertyName = "MaNH";
            this.maNHDataGridViewTextBoxColumn.HeaderText = "Mã Năm Học";
            this.maNHDataGridViewTextBoxColumn.Name = "maNHDataGridViewTextBoxColumn";
            // 
            // tenNHDataGridViewTextBoxColumn
            // 
            this.tenNHDataGridViewTextBoxColumn.DataPropertyName = "TenNH";
            this.tenNHDataGridViewTextBoxColumn.HeaderText = "Tên Năm học";
            this.tenNHDataGridViewTextBoxColumn.Name = "tenNHDataGridViewTextBoxColumn";
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHS_GV1DataSet;
            // 
            // qLHS_GV1DataSet
            // 
            this.qLHS_GV1DataSet.DataSetName = "QLHS_GV1DataSet";
            this.qLHS_GV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txbTenNH);
            this.groupBox1.Controls.Add(this.mttXoa);
            this.groupBox1.Controls.Add(this.txbMaNH);
            this.groupBox1.Controls.Add(this.mttSua);
            this.groupBox1.Controls.Add(this.txbTenNH1);
            this.groupBox1.Controls.Add(this.mttThem);
            this.groupBox1.Controls.Add(this.mttReload);
            this.groupBox1.Location = new System.Drawing.Point(23, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 484);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin năm học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txbTK);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Location = new System.Drawing.Point(469, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 484);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // NamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NamHoc";
            this.Text = "Thông tin năm học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NamHoc_FormClosed);
            this.Load += new System.EventHandler(this.NamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txbTenNH;
        private MetroFramework.Controls.MetroTextBox txbMaNH;
        private MetroFramework.Controls.MetroTextBox txbTenNH1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txbTK;
        private MetroFramework.Controls.MetroButton btnTK;
        private MetroFramework.Controls.MetroTile mttReload;
        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile mttSua;
        private MetroFramework.Controls.MetroTile mttXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLHS_GV1DataSet qLHS_GV1DataSet;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHS_GV1DataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}