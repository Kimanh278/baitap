namespace WQLHS_GV1
{
    partial class DuaraReport
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
            this.mttThem = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mttThem
            // 
            this.mttThem.Location = new System.Drawing.Point(157, 136);
            this.mttThem.Name = "mttThem";
            this.mttThem.Size = new System.Drawing.Size(114, 105);
            this.mttThem.Style = MetroFramework.MetroColorStyle.White;
            this.mttThem.TabIndex = 43;
            this.mttThem.TileImage = global::WQLHS_GV1.Properties.Resources.truonghoc;
            this.mttThem.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(544, 146);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(114, 105);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 44;
            this.metroTile1.TileImage = global::WQLHS_GV1.Properties.Resources.ttn3;
            this.metroTile1.UseTileImage = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(134, 282);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(168, 23);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Đưa ra biểu mẫu điêu chi tiết của học sinh";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(529, 282);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(160, 23);
            this.metroButton2.TabIndex = 46;
            this.metroButton2.Text = "Đưa ra xếp loại học lực";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DuaraReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mttThem);
            this.Name = "DuaraReport";
            this.Text = "Đưa ra Report";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mttThem;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}