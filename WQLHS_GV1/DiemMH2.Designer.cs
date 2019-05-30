namespace WQLHS_GV1
{
    partial class DiemMH2
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
            this.btnD4 = new MetroFramework.Controls.MetroButton();
            this.btnD2 = new MetroFramework.Controls.MetroButton();
            this.mttReload = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(182, 299);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(94, 23);
            this.btnD4.TabIndex = 1;
            this.btnD4.Text = "Điểm chi tiết";
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD2
            // 
            this.btnD2.Location = new System.Drawing.Point(486, 287);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(95, 35);
            this.btnD2.TabIndex = 3;
            this.btnD2.Text = "Xếp loại học lực";
            this.btnD2.Click += new System.EventHandler(this.btnD2_Click);
            // 
            // mttReload
            // 
            this.mttReload.Location = new System.Drawing.Point(148, 140);
            this.mttReload.Name = "mttReload";
            this.mttReload.Size = new System.Drawing.Size(148, 141);
            this.mttReload.Style = MetroFramework.MetroColorStyle.White;
            this.mttReload.TabIndex = 150;
            this.mttReload.TileImage = global::WQLHS_GV1.Properties.Resources.HB3;
            this.mttReload.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(462, 140);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(148, 141);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 151;
            this.metroTile1.TileImage = global::WQLHS_GV1.Properties.Resources.tt2;
            this.metroTile1.UseTileImage = true;
            // 
            // DiemMH2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WQLHS_GV1.Properties.Resources.ttn67;
            this.ClientSize = new System.Drawing.Size(650, 418);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mttReload);
            this.Controls.Add(this.btnD2);
            this.Controls.Add(this.btnD4);
            this.Name = "DiemMH2";
            this.Text = "Chi tiết  điểm môn học";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnD4;
        private MetroFramework.Controls.MetroButton btnD2;
        private MetroFramework.Controls.MetroTile mttReload;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}