namespace WQLHS_GV1
{
    partial class GiangDaycs
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
            this.txbTK = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnTK = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbMaGV = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txbTenGV = new MetroFramework.Controls.MetroTextBox();
            this.txbTenMH = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHS_GV1DataSet7 = new WQLHS_GV1.QLHS_GV1DataSet7();
            this.giangDayTableAdapter = new WQLHS_GV1.QLHS_GV1DataSet7TableAdapters.GiangDayTableAdapter();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(208, 19);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(214, 23);
            this.txbTK.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Nhập thông tin tìm kiếm";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(473, 21);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(93, 20);
            this.btnTK.TabIndex = 12;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Mã giáo viên";
            // 
            // txbMaGV
            // 
            this.txbMaGV.Location = new System.Drawing.Point(154, 31);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.Size = new System.Drawing.Size(142, 23);
            this.txbMaGV.TabIndex = 16;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Tên giáo viên";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Tên môn học";
            // 
            // txbTenGV
            // 
            this.txbTenGV.Location = new System.Drawing.Point(154, 92);
            this.txbTenGV.Name = "txbTenGV";
            this.txbTenGV.Size = new System.Drawing.Size(142, 23);
            this.txbTenGV.TabIndex = 19;
            // 
            // txbTenMH
            // 
            this.txbTenMH.Location = new System.Drawing.Point(154, 152);
            this.txbTenMH.Name = "txbTenMH";
            this.txbTenMH.Size = new System.Drawing.Size(142, 23);
            this.txbTenMH.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.maGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.tenMHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giangDayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 252);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Mã giáo viên";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên giáo viên";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // tenMHDataGridViewTextBoxColumn
            // 
            this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
            // 
            // giangDayBindingSource
            // 
            this.giangDayBindingSource.DataMember = "GiangDay";
            this.giangDayBindingSource.DataSource = this.qLHS_GV1DataSet7;
            // 
            // qLHS_GV1DataSet7
            // 
            this.qLHS_GV1DataSet7.DataSetName = "QLHS_GV1DataSet7";
            this.qLHS_GV1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangDayTableAdapter
            // 
            this.giangDayTableAdapter.ClearBeforeFill = true;
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(65, 202);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(118, 105);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 41;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.reload;
            this.mttReload.UseTileImage = true;
            this.mttReload.Click += new System.EventHandler(this.mttReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.mttReload);
            this.groupBox1.Controls.Add(this.txbMaGV);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txbTenMH);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txbTenGV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 360);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng dạy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txbTK);
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(357, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 360);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // GiangDaycs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiangDaycs";
            this.Text = "Thông tin giảng dạy";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.GiangDaycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHS_GV1DataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txbTK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnTK;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbMaGV;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txbTenGV;
        private MetroFramework.Controls.MetroTextBox txbTenMH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLHS_GV1DataSet7 qLHS_GV1DataSet7;
        private System.Windows.Forms.BindingSource giangDayBindingSource;
        private QLHS_GV1DataSet7TableAdapters.GiangDayTableAdapter giangDayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile mttReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}