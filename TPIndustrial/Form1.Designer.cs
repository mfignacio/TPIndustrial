namespace Industrial2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEjecutar = new MetroFramework.Controls.MetroTile();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.cboDiseño = new MetroFramework.Controls.MetroComboBox();
            this.CboComprasTipo = new MetroFramework.Controls.MetroComboBox();
            this.cboComprasProducto = new MetroFramework.Controls.MetroComboBox();
            this.cboElementosTipo = new MetroFramework.Controls.MetroComboBox();
            this.cboElementosProducto = new MetroFramework.Controls.MetroComboBox();
            this.radiobtnDiseño = new MetroFramework.Controls.MetroRadioButton();
            this.radiobtnCompras = new MetroFramework.Controls.MetroRadioButton();
            this.radiobtnComponen = new MetroFramework.Controls.MetroRadioButton();
            this.btnABM = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboFecha = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEjecutar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.cboDiseño);
            this.groupBox1.Controls.Add(this.CboComprasTipo);
            this.groupBox1.Controls.Add(this.cboComprasProducto);
            this.groupBox1.Controls.Add(this.cboElementosTipo);
            this.groupBox1.Controls.Add(this.cboElementosProducto);
            this.groupBox1.Controls.Add(this.radiobtnDiseño);
            this.groupBox1.Controls.Add(this.radiobtnCompras);
            this.groupBox1.Controls.Add(this.radiobtnComponen);
            this.groupBox1.Location = new System.Drawing.Point(23, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.ActiveControl = null;
            this.btnEjecutar.Location = new System.Drawing.Point(644, 126);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(77, 46);
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEjecutar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEjecutar.UseSelectable = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCantidad.Lines = new string[] {
        "1"};
            this.txtCantidad.Location = new System.Drawing.Point(644, 93);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(72, 23);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboDiseño
            // 
            this.cboDiseño.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboDiseño.FormattingEnabled = true;
            this.cboDiseño.ItemHeight = 23;
            this.cboDiseño.Location = new System.Drawing.Point(237, 126);
            this.cboDiseño.Name = "cboDiseño";
            this.cboDiseño.Size = new System.Drawing.Size(121, 29);
            this.cboDiseño.TabIndex = 7;
            this.cboDiseño.UseSelectable = true;
            this.cboDiseño.SelectedIndexChanged += new System.EventHandler(this.cboDiseño_SelectedIndexChanged);
            this.cboDiseño.Click += new System.EventHandler(this.cboDiseño_Click_1);
            // 
            // CboComprasTipo
            // 
            this.CboComprasTipo.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CboComprasTipo.FormattingEnabled = true;
            this.CboComprasTipo.ItemHeight = 23;
            this.CboComprasTipo.Location = new System.Drawing.Point(424, 87);
            this.CboComprasTipo.Name = "CboComprasTipo";
            this.CboComprasTipo.Size = new System.Drawing.Size(121, 29);
            this.CboComprasTipo.TabIndex = 6;
            this.CboComprasTipo.UseSelectable = true;
            // 
            // cboComprasProducto
            // 
            this.cboComprasProducto.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboComprasProducto.FormattingEnabled = true;
            this.cboComprasProducto.ItemHeight = 23;
            this.cboComprasProducto.Location = new System.Drawing.Point(237, 87);
            this.cboComprasProducto.Name = "cboComprasProducto";
            this.cboComprasProducto.Size = new System.Drawing.Size(121, 29);
            this.cboComprasProducto.TabIndex = 5;
            this.cboComprasProducto.UseSelectable = true;
            this.cboComprasProducto.SelectedIndexChanged += new System.EventHandler(this.cboComprasProducto_SelectedIndexChanged);
            this.cboComprasProducto.Click += new System.EventHandler(this.cboComprasProducto_Click_1);
            // 
            // cboElementosTipo
            // 
            this.cboElementosTipo.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboElementosTipo.FormattingEnabled = true;
            this.cboElementosTipo.ItemHeight = 23;
            this.cboElementosTipo.Location = new System.Drawing.Point(424, 33);
            this.cboElementosTipo.Name = "cboElementosTipo";
            this.cboElementosTipo.Size = new System.Drawing.Size(121, 29);
            this.cboElementosTipo.TabIndex = 4;
            this.cboElementosTipo.UseSelectable = true;
            // 
            // cboElementosProducto
            // 
            this.cboElementosProducto.DisplayMember = "(none)";
            this.cboElementosProducto.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboElementosProducto.FormattingEnabled = true;
            this.cboElementosProducto.ItemHeight = 23;
            this.cboElementosProducto.Location = new System.Drawing.Point(237, 33);
            this.cboElementosProducto.Name = "cboElementosProducto";
            this.cboElementosProducto.Size = new System.Drawing.Size(121, 29);
            this.cboElementosProducto.TabIndex = 3;
            this.cboElementosProducto.UseSelectable = true;
            this.cboElementosProducto.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.cboElementosProducto.Click += new System.EventHandler(this.cboElementosProducto_Click);
            // 
            // radiobtnDiseño
            // 
            this.radiobtnDiseño.AutoSize = true;
            this.radiobtnDiseño.Location = new System.Drawing.Point(6, 140);
            this.radiobtnDiseño.Name = "radiobtnDiseño";
            this.radiobtnDiseño.Size = new System.Drawing.Size(199, 15);
            this.radiobtnDiseño.TabIndex = 2;
            this.radiobtnDiseño.Text = "Productos utilizados en el diseño:";
            this.radiobtnDiseño.UseSelectable = true;
            this.radiobtnDiseño.Click += new System.EventHandler(this.radiobtnDiseño_Click);
            // 
            // radiobtnCompras
            // 
            this.radiobtnCompras.AutoSize = true;
            this.radiobtnCompras.Location = new System.Drawing.Point(6, 95);
            this.radiobtnCompras.Name = "radiobtnCompras";
            this.radiobtnCompras.Size = new System.Drawing.Size(411, 15);
            this.radiobtnCompras.TabIndex = 1;
            this.radiobtnCompras.Text = "Compras para producir el producto                                                " +
    "     del tipo:";
            this.radiobtnCompras.UseSelectable = true;
            this.radiobtnCompras.Click += new System.EventHandler(this.radiobtnCompras_Click);
            // 
            // radiobtnComponen
            // 
            this.radiobtnComponen.AutoSize = true;
            this.radiobtnComponen.Location = new System.Drawing.Point(7, 47);
            this.radiobtnComponen.Name = "radiobtnComponen";
            this.radiobtnComponen.Size = new System.Drawing.Size(410, 15);
            this.radiobtnComponen.TabIndex = 0;
            this.radiobtnComponen.Text = "Elementos que componen el producto                                               " +
    "del tipo:";
            this.radiobtnComponen.UseSelectable = true;
            this.radiobtnComponen.Click += new System.EventHandler(this.radiobtnComponen_Click);
            // 
            // btnABM
            // 
            this.btnABM.ActiveControl = null;
            this.btnABM.Location = new System.Drawing.Point(335, 66);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(77, 46);
            this.btnABM.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnABM.TabIndex = 11;
            this.btnABM.Text = "ABM";
            this.btnABM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnABM.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnABM.UseSelectable = true;
            this.btnABM.UseStyleColors = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Fecha seleccionada:";
            // 
            // cboFecha
            // 
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.ItemHeight = 23;
            this.cboFecha.Location = new System.Drawing.Point(160, 143);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(183, 29);
            this.cboFecha.TabIndex = 13;
            this.cboFecha.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 386);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Tag = "Producto";
            this.Text = "Lista de materiales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboDiseño;
        private MetroFramework.Controls.MetroComboBox CboComprasTipo;
        private MetroFramework.Controls.MetroComboBox cboComprasProducto;
        private MetroFramework.Controls.MetroComboBox cboElementosTipo;
        private MetroFramework.Controls.MetroComboBox cboElementosProducto;
        private MetroFramework.Controls.MetroRadioButton radiobtnDiseño;
        private MetroFramework.Controls.MetroRadioButton radiobtnCompras;
        private MetroFramework.Controls.MetroRadioButton radiobtnComponen;
        private MetroFramework.Controls.MetroTile btnEjecutar;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btnABM;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboFecha;
    }
}

