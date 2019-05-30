namespace WQLHS_GV1
{
    partial class DN
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
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnDN = new MetroFramework.Controls.MetroButton();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.mtbMK = new MetroFramework.Controls.MetroTextBox();
            this.mtbMaGV = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(69, 12);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(114, 105);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile3.TabIndex = 48;
            this.metroTile3.TileImage = global::WQLHS_GV1.Properties.Resources.truonghoc;
            this.metroTile3.UseTileImage = true;
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(579, 329);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 47;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.hs;
            this.mttThem.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(240, 221);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(89, 23);
            this.metroTile2.TabIndex = 46;
            this.metroTile2.Text = "Mật khẩu";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(240, 153);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(116, 23);
            this.metroTile1.TabIndex = 45;
            this.metroTile1.Text = "Tên đăng nhập";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroLabel3.Location = new System.Drawing.Point(274, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(231, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Hệ thống quản lí học sinh và giáo viên";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(270, 282);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(75, 23);
            this.btnDN.TabIndex = 43;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(416, 282);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // mtbMK
            // 
            this.mtbMK.Location = new System.Drawing.Point(382, 221);
            this.mtbMK.Name = "mtbMK";
            this.mtbMK.PasswordChar = '●';
            this.mtbMK.Size = new System.Drawing.Size(135, 23);
            this.mtbMK.TabIndex = 41;
            this.mtbMK.UseSystemPasswordChar = true;
            // 
            // mtbMaGV
            // 
            this.mtbMaGV.Location = new System.Drawing.Point(382, 154);
            this.mtbMaGV.Name = "mtbMaGV";
            this.mtbMaGV.Size = new System.Drawing.Size(135, 23);
            this.mtbMaGV.TabIndex = 40;
            // 
            // DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.mttThem);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.mtbMK);
            this.Controls.Add(this.mtbMaGV);
            this.Name = "DN";
            this.Text = "DN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnDN;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroTextBox mtbMK;
        private MetroFramework.Controls.MetroTextBox mtbMaGV;
    }
}