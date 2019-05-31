namespace WQLHS_GV1
{
    partial class Lop
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
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet = new WQLHS_GV1.QLHS_GV1DataSet();
            this.mttXoa = new MetroFramework.Controls.MetroTile();
            this.mttSua = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbTK = new MetroFramework.Controls.MetroTextBox();
            this.btnTK = new MetroFramework.Controls.MetroButton();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.LOPTableAdapter();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.NAMHOCTableAdapter();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.GIAOVIENTableAdapter();
            this.lOPBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txbMaLop = new MetroFramework.Controls.MetroTextBox();
            this.txbTenLop = new MetroFramework.Controls.MetroTextBox();
            this.cbbMaNH = new MetroFramework.Controls.MetroComboBox();
            this.txbMaGV = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // mttXoa
            // 
            this.mttXoa.Location = new System.Drawing.Point(52, 340);
            this.mttXoa.Name = "mttXoa";
            this.mttXoa.Size = new System.Drawing.Size(117, 105);
            this.mttXoa.Style = MetroFramework.MetroColorStyle.White;
            this.mttXoa.TabIndex = 40;
            this.mttXoa.TileImage = global::WQLHS_GV1.Properties.Resources.delete;
            this.mttXoa.UseTileImage = true;
            this.mttXoa.Click += new System.EventHandler(this.mttXoa_Click);
            // 
            // mttSua
            // 
            this.mttSua.Location = new System.Drawing.Point(232, 229);
            this.mttSua.Name = "mttSua";
            this.mttSua.Size = new System.Drawing.Size(104, 105);
            this.mttSua.Style = MetroFramework.MetroColorStyle.White;
            this.mttSua.TabIndex = 41;
            this.mttSua.TileImage = global::WQLHS_GV1.Properties.Resources.edit;
            this.mttSua.UseTileImage = true;
            this.mttSua.Click += new System.EventHandler(this.mttSua_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(736, 226);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(114, 105);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.White;
            this.mtAdd.TabIndex = 42;
            this.mtAdd.UseTileImage = true;
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(52, 229);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 43;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.add;
            this.mttThem.UseTileImage = true;
            this.mttThem.Click += new System.EventHandler(this.mttThem_Click);
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(232, 340);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(118, 105);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 44;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.reload;
            this.mttReload.UseTileImage = true;
            this.mttReload.Click += new System.EventHandler(this.mttReload_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 45;
            this.metroLabel6.Text = "Nhập thông tin cần tìm";
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(173, 56);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(224, 23);
            this.txbTK.TabIndex = 46;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(442, 56);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 47;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLHS_GV1DataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.qLHS_GV1DataSet;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.qLHS_GV1DataSet;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource2
            // 
            this.lOPBindingSource2.DataMember = "LOP";
            this.lOPBindingSource2.DataSource = this.qLHS_GV1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.maNHDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 258);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            // 
            // maNHDataGridViewTextBoxColumn
            // 
            this.maNHDataGridViewTextBoxColumn.DataPropertyName = "MaNH";
            this.maNHDataGridViewTextBoxColumn.HeaderText = "Mã Năm học";
            this.maNHDataGridViewTextBoxColumn.Name = "maNHDataGridViewTextBoxColumn";
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Giáo viên chủ nhiệm";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã Lớp";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên Lớp";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Mã năm học";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(40, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Mã Giáo viên";
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(148, 31);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(121, 23);
            this.txbMaLop.TabIndex = 4;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Location = new System.Drawing.Point(148, 74);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(121, 23);
            this.txbTenLop.TabIndex = 5;
            // 
            // cbbMaNH
            // 
            this.cbbMaNH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nAMHOCBindingSource, "MaNH", true));
            this.cbbMaNH.DataSource = this.nAMHOCBindingSource;
            this.cbbMaNH.DisplayMember = "MaNH";
            this.cbbMaNH.FormattingEnabled = true;
            this.cbbMaNH.ItemHeight = 23;
            this.cbbMaNH.Location = new System.Drawing.Point(148, 123);
            this.cbbMaNH.Name = "cbbMaNH";
            this.cbbMaNH.Size = new System.Drawing.Size(121, 29);
            this.cbbMaNH.TabIndex = 6;
            this.cbbMaNH.ValueMember = "MaNH";
            // 
            // txbMaGV
            // 
            this.txbMaGV.Location = new System.Drawing.Point(148, 175);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.Size = new System.Drawing.Size(121, 23);
            this.txbMaGV.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txbMaLop);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.mttReload);
            this.groupBox1.Controls.Add(this.mttXoa);
            this.groupBox1.Controls.Add(this.txbTenLop);
            this.groupBox1.Controls.Add(this.mttThem);
            this.groupBox1.Controls.Add(this.mttSua);
            this.groupBox1.Controls.Add(this.cbbMaNH);
            this.groupBox1.Controls.Add(this.txbMaGV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 447);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txbTK);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(469, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 447);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtAdd);
            this.Name = "Lop";
            this.Text = "Thông tin lớp học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lop_FormClosed);
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mttXoa;
        private MetroFramework.Controls.MetroTile mttSua;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile mttReload;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txbTK;
        private MetroFramework.Controls.MetroButton btnTK;
        private QLHS_GV1DataSet qLHS_GV1DataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLHS_GV1DataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHS_GV1DataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private QLHS_GV1DataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txbMaLop;
        private MetroFramework.Controls.MetroTextBox txbTenLop;
        private MetroFramework.Controls.MetroComboBox cbbMaNH;
        private MetroFramework.Controls.MetroTextBox txbMaGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

