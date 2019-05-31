namespace WQLHS_GV1
{
    partial class MonHoc
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet = new WQLHS_GV1.QLHS_GV1DataSet();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.MONHOCTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbTK = new MetroFramework.Controls.MetroTextBox();
            this.btnTK = new MetroFramework.Controls.MetroButton();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.mttSua = new MetroFramework.Controls.MetroTile();
            this.mttXoa = new MetroFramework.Controls.MetroTile();
            this.txbMaMH = new MetroFramework.Controls.MetroTextBox();
            this.txbTenMH = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbMaMH = new System.Windows.Forms.ComboBox();
            this.cbbMaHK = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnTìmKiem = new MetroFramework.Controls.MetroButton();
            this.qLHS_GV1DataSet12 = new WQLHS_GV1.QLHS_GV1DataSet12();
            this.selectDiemMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.select_DiemMHTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet12TableAdapters.Select_DiemMHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDiemMHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã môn học";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên môn học";
            // 
            // mONHOCBindingSource1
            // 
            this.mONHOCBindingSource1.DataMember = "MONHOC";
            this.mONHOCBindingSource1.DataSource = this.qLHS_GV1DataSet;
            // 
            // qLHS_GV1DataSet
            // 
            this.qLHS_GV1DataSet.DataSetName = "QLHS_GV1DataSet";
            this.qLHS_GV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLHS_GV1DataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 209);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvMonHoc);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Nhập thông tin cần tìm";
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(204, 39);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(224, 23);
            this.txbTK.TabIndex = 47;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(493, 39);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 48;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(37, 164);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(118, 105);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 49;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.reload;
            this.mttReload.UseTileImage = true;
            this.mttReload.Click += new System.EventHandler(this.mttReload_Click);
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(227, 164);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 50;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.add;
            this.mttThem.UseTileImage = true;
            this.mttThem.Click += new System.EventHandler(this.mttThem_Click);
            // 
            // mttSua
            // 
            this.mttSua.Location = new System.Drawing.Point(37, 304);
            this.mttSua.Name = "mttSua";
            this.mttSua.Size = new System.Drawing.Size(104, 105);
            this.mttSua.Style = MetroFramework.MetroColorStyle.White;
            this.mttSua.TabIndex = 51;
            this.mttSua.TileImage = global::WQLHS_GV1.Properties.Resources.edit;
            this.mttSua.UseTileImage = true;
            this.mttSua.Click += new System.EventHandler(this.mttSua_Click);
            // 
            // mttXoa
            // 
            this.mttXoa.Location = new System.Drawing.Point(227, 304);
            this.mttXoa.Name = "mttXoa";
            this.mttXoa.Size = new System.Drawing.Size(117, 105);
            this.mttXoa.Style = MetroFramework.MetroColorStyle.White;
            this.mttXoa.TabIndex = 52;
            this.mttXoa.TileImage = global::WQLHS_GV1.Properties.Resources.delete;
            this.mttXoa.UseTileImage = true;
            this.mttXoa.Click += new System.EventHandler(this.mttXoa_Click);
            // 
            // txbMaMH
            // 
            this.txbMaMH.Location = new System.Drawing.Point(170, 39);
            this.txbMaMH.Name = "txbMaMH";
            this.txbMaMH.Size = new System.Drawing.Size(145, 23);
            this.txbMaMH.TabIndex = 53;
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(170, 99);
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(145, 23);
            this.txbTenMH.TabIndex = 54;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(332, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(118, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 55;
            this.metroTile1.TileImage = global::WQLHS_GV1.Properties.Resources.ttn3;
            this.metroTile1.UseTileImage = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txbMaMH);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.mttXoa);
            this.groupBox1.Controls.Add(this.txbTenMH);
            this.groupBox1.Controls.Add(this.mttSua);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.mttThem);
            this.groupBox1.Controls.Add(this.mttReload);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 429);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnTìmKiem);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.cbbMaHK);
            this.groupBox2.Controls.Add(this.cbbMaMH);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txbTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(445, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 429);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Tìm kiếm điểm";
            // 
            // cbbMaMH
            // 
            this.cbbMaMH.FormattingEnabled = true;
            this.cbbMaMH.Location = new System.Drawing.Point(159, 121);
            this.cbbMaMH.Name = "cbbMaMH";
            this.cbbMaMH.Size = new System.Drawing.Size(121, 27);
            this.cbbMaMH.TabIndex = 50;
            // 
            // cbbMaHK
            // 
            this.cbbMaHK.FormattingEnabled = true;
            this.cbbMaHK.Location = new System.Drawing.Point(385, 121);
            this.cbbMaHK.Name = "cbbMaHK";
            this.cbbMaHK.Size = new System.Drawing.Size(121, 27);
            this.cbbMaHK.TabIndex = 51;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Mã môn học";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(303, 129);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Học kỳ";
            // 
            // btnTìmKiem
            // 
            this.btnTìmKiem.Location = new System.Drawing.Point(540, 121);
            this.btnTìmKiem.Name = "btnTìmKiem";
            this.btnTìmKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTìmKiem.TabIndex = 54;
            this.btnTìmKiem.Text = "Tìm kiếm";
            this.btnTìmKiem.Click += new System.EventHandler(this.btnTìmKiem_Click);
            // 
            // qLHS_GV1DataSet12
            // 
            this.qLHS_GV1DataSet12.DataSetName = "QLHS_GV1DataSet12";
            this.qLHS_GV1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDiemMHBindingSource
            // 
            this.selectDiemMHBindingSource.DataMember = "Select_DiemMH";
            this.selectDiemMHBindingSource.DataSource = this.qLHS_GV1DataSet12;
            // 
            // select_DiemMHTableAdapter
            // 
            this.select_DiemMHTableAdapter.ClearBeforeFill = true;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTile1);
            this.Name = "MonHoc";
            this.Text = "Thông tin môn học";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDiemMHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private QLHS_GV1DataSet qLHS_GV1DataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLHS_GV1DataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txbTK;
        private MetroFramework.Controls.MetroButton btnTK;
        private MetroFramework.Controls.MetroTile mttReload;
        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile mttSua;
        private MetroFramework.Controls.MetroTile mttXoa;
        private MetroFramework.Controls.MetroTextBox txbMaMH;
        private MetroFramework.Controls.MetroTextBox txbTenMH;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnTìmKiem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cbbMaHK;
        private System.Windows.Forms.ComboBox cbbMaMH;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private QLHS_GV1DataSet12 qLHS_GV1DataSet12;
        private System.Windows.Forms.BindingSource selectDiemMHBindingSource;
        private QLHS_GV1DataSet12TableAdapters.Select_DiemMHTableAdapter select_DiemMHTableAdapter;
    }
}