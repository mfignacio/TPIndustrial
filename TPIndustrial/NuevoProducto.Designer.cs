namespace TPIndustrial
{
    partial class NuevoProducto
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNuevoProducto = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Producto:";
            // 
            // txtNuevoProducto
            // 
            // 
            // 
            // 
            this.txtNuevoProducto.CustomButton.Image = null;
            this.txtNuevoProducto.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtNuevoProducto.CustomButton.Name = "";
            this.txtNuevoProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNuevoProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevoProducto.CustomButton.TabIndex = 1;
            this.txtNuevoProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevoProducto.CustomButton.UseSelectable = true;
            this.txtNuevoProducto.CustomButton.Visible = false;
            this.txtNuevoProducto.Lines = new string[0];
            this.txtNuevoProducto.Location = new System.Drawing.Point(96, 87);
            this.txtNuevoProducto.MaxLength = 32767;
            this.txtNuevoProducto.Name = "txtNuevoProducto";
            this.txtNuevoProducto.PasswordChar = '\0';
            this.txtNuevoProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevoProducto.SelectedText = "";
            this.txtNuevoProducto.SelectionLength = 0;
            this.txtNuevoProducto.SelectionStart = 0;
            this.txtNuevoProducto.ShortcutsEnabled = true;
            this.txtNuevoProducto.Size = new System.Drawing.Size(182, 23);
            this.txtNuevoProducto.TabIndex = 1;
            this.txtNuevoProducto.UseSelectable = true;
            this.txtNuevoProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevoProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(380, 148);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(116, 38);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Hecho";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Location = new System.Drawing.Point(96, 130);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(182, 29);
            this.cboTipo.TabIndex = 4;
            this.cboTipo.UseSelectable = true;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 209);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtNuevoProducto);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NuevoProducto";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNuevoProducto;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboTipo;
    }
}