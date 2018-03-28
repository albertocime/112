namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    partial class frm_verEquipos_admin
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
            this.btn_cerrar_VerEquipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar_VerEquipos
            // 
            this.btn_cerrar_VerEquipos.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_VerEquipos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_VerEquipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar_VerEquipos.BorderRadius = 0;
            this.btn_cerrar_VerEquipos.ButtonText = "X";
            this.btn_cerrar_VerEquipos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrar_VerEquipos.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.btn_cerrar_VerEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_VerEquipos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_cerrar_VerEquipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_VerEquipos.Iconimage = null;
            this.btn_cerrar_VerEquipos.Iconimage_right = null;
            this.btn_cerrar_VerEquipos.Iconimage_right_Selected = null;
            this.btn_cerrar_VerEquipos.Iconimage_Selected = null;
            this.btn_cerrar_VerEquipos.IconMarginLeft = 0;
            this.btn_cerrar_VerEquipos.IconMarginRight = 0;
            this.btn_cerrar_VerEquipos.IconRightVisible = true;
            this.btn_cerrar_VerEquipos.IconRightZoom = 0D;
            this.btn_cerrar_VerEquipos.IconVisible = true;
            this.btn_cerrar_VerEquipos.IconZoom = 90D;
            this.btn_cerrar_VerEquipos.IsTab = false;
            this.btn_cerrar_VerEquipos.Location = new System.Drawing.Point(765, -1);
            this.btn_cerrar_VerEquipos.Margin = new System.Windows.Forms.Padding(8);
            this.btn_cerrar_VerEquipos.Name = "btn_cerrar_VerEquipos";
            this.btn_cerrar_VerEquipos.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_VerEquipos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cerrar_VerEquipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cerrar_VerEquipos.selected = false;
            this.btn_cerrar_VerEquipos.Size = new System.Drawing.Size(45, 35);
            this.btn_cerrar_VerEquipos.TabIndex = 22;
            this.btn_cerrar_VerEquipos.Text = "X";
            this.btn_cerrar_VerEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrar_VerEquipos.Textcolor = System.Drawing.Color.DimGray;
            this.btn_cerrar_VerEquipos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 312);
            this.dataGridView1.TabIndex = 23;
            // 
            // frm_verEquipos_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cerrar_VerEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_verEquipos_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_verEquipos_admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar_VerEquipos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}