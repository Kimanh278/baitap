namespace WQLHS_GV1
{
    partial class HocKy
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ccbMaHK = new MetroFramework.Controls.MetroComboBox();
            this.hOCKYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet = new WQLHS_GV1.QLHS_GV1DataSet();
            this.ccbTenHK = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbTK = new MetroFramework.Controls.MetroTextBox();
            this.btnTK = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new WQLHS_GV1.QLHS_GV1DataSetTableAdapters.HOCKYTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mttXoa = new MetroFramework.Controls.MetroTile();
            this.mttSua = new MetroFramework.Controls.MetroTile();
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã học kỳ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên học kỳ";
            // 
            // ccbMaHK
            // 
            this.ccbMaHK.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hOCKYBindingSource1, "MaHK", true));
            this.ccbMaHK.DataSource = this.hOCKYBindingSource1;
            this.ccbMaHK.DisplayMember = "MaHK";
            this.ccbMaHK.FormattingEnabled = true;
            this.ccbMaHK.ItemHeight = 23;
            this.ccbMaHK.Location = new System.Drawing.Point(175, 45);
            this.ccbMaHK.Name = "ccbMaHK";
            this.ccbMaHK.Size = new System.Drawing.Size(121, 29);
            this.ccbMaHK.TabIndex = 2;
            this.ccbMaHK.ValueMember = "MaHK";
            // 
            // hOCKYBindingSource1
            // 
            this.hOCKYBindingSource1.DataMember = "HOCKY";
            this.hOCKYBindingSource1.DataSource = this.qLHS_GV1DataSet;
            // 
            // qLHS_GV1DataSet
            // 
            this.qLHS_GV1DataSet.DataSetName = "QLHS_GV1DataSet";
            this.qLHS_GV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ccbTenHK
            // 
            this.ccbTenHK.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hOCKYBindingSource1, "TenHK", true));
            this.ccbTenHK.DataSource = this.hOCKYBindingSource1;
            this.ccbTenHK.DisplayMember = "TenHK";
            this.ccbTenHK.FormattingEnabled = true;
            this.ccbTenHK.ItemHeight = 23;
            this.ccbTenHK.Location = new System.Drawing.Point(175, 99);
            this.ccbTenHK.Name = "ccbTenHK";
            this.ccbTenHK.Size = new System.Drawing.Size(121, 29);
            this.ccbTenHK.TabIndex = 3;
            this.ccbTenHK.ValueMember = "TenHK";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 45);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 43;
            this.metroLabel6.Text = "Nhập thông tin cần tìm";
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(150, 41);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(224, 23);
            this.txbTK.TabIndex = 44;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(421, 41);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 45;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
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
            this.maHKDataGridViewTextBoxColumn,
            this.tenHKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOCKYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 198);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // maHKDataGridViewTextBoxColumn
            // 
            this.maHKDataGridViewTextBoxColumn.DataPropertyName = "MaHK";
            this.maHKDataGridViewTextBoxColumn.HeaderText = "Mã Học Kỳ";
            this.maHKDataGridViewTextBoxColumn.Name = "maHKDataGridViewTextBoxColumn";
            // 
            // tenHKDataGridViewTextBoxColumn
            // 
            this.tenHKDataGridViewTextBoxColumn.DataPropertyName = "TenHK";
            this.tenHKDataGridViewTextBoxColumn.HeaderText = "Tên học kỳ";
            this.tenHKDataGridViewTextBoxColumn.Name = "tenHKDataGridViewTextBoxColumn";
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.qLHS_GV1DataSet;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.mttXoa);
            this.groupBox1.Controls.Add(this.mttSua);
            this.groupBox1.Controls.Add(this.mttThem);
            this.groupBox1.Controls.Add(this.mttReload);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.ccbTenHK);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.ccbMaHK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 428);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học kỳ";
            // 
            // mttXoa
            // 
            this.mttXoa.Location = new System.Drawing.Point(239, 323);
            this.mttXoa.Name = "mttXoa";
            this.mttXoa.Size = new System.Drawing.Size(117, 93);
            this.mttXoa.Style = MetroFramework.MetroColorStyle.White;
            this.mttXoa.TabIndex = 53;
            this.mttXoa.TileImage = global::WQLHS_GV1.Properties.Resources.delete;
            this.mttXoa.UseTileImage = true;
            // 
            // mttSua
            // 
            this.mttSua.Location = new System.Drawing.Point(239, 188);
            this.mttSua.Name = "mttSua";
            this.mttSua.Size = new System.Drawing.Size(104, 105);
            this.mttSua.Style = MetroFramework.MetroColorStyle.White;
            this.mttSua.TabIndex = 52;
            this.mttSua.TileImage = global::WQLHS_GV1.Properties.Resources.edit;
            this.mttSua.UseTileImage = true;
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(52, 311);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 51;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.add;
            this.mttThem.UseTileImage = true;
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(52, 188);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(118, 105);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 50;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.reload;
            this.mttReload.UseTileImage = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Controls.Add(this.txbTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(468, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 428);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // HocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HocKy";
            this.Text = "Thông tin học kỳ";
            this.Load += new System.EventHandler(this.HocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ccbMaHK;
        private MetroFramework.Controls.MetroComboBox ccbTenHK;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txbTK;
        private MetroFramework.Controls.MetroButton btnTK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLHS_GV1DataSet qLHS_GV1DataSet;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QLHS_GV1DataSetTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hOCKYBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile mttXoa;
        private MetroFramework.Controls.MetroTile mttSua;
        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile mttReload;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}