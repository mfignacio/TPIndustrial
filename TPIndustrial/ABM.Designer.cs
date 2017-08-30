namespace TPIndustrial
{
    partial class ABM
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
            this.cboProductos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroTile();
            this.btnEliminar = new MetroFramework.Controls.MetroTile();
            this.btnModificar = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboComponentes = new MetroFramework.Controls.MetroComboBox();
            this.btnTerminado = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new MetroFramework.Controls.MetroTile();
            this.dataGridViewABM = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABM)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.ItemHeight = 23;
            this.cboProductos.Location = new System.Drawing.Point(115, 19);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(216, 29);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.UseSelectable = true;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveControl = null;
            this.btnAgregar.Location = new System.Drawing.Point(337, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 38);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveControl = null;
            this.btnEliminar.Location = new System.Drawing.Point(508, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 38);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ActiveControl = null;
            this.btnModificar.Location = new System.Drawing.Point(414, 59);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 39);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Componentes";
            // 
            // cboComponentes
            // 
            this.cboComponentes.FormattingEnabled = true;
            this.cboComponentes.ItemHeight = 23;
            this.cboComponentes.Location = new System.Drawing.Point(115, 70);
            this.cboComponentes.Name = "cboComponentes";
            this.cboComponentes.Size = new System.Drawing.Size(216, 29);
            this.cboComponentes.TabIndex = 6;
            this.cboComponentes.UseSelectable = true;
            // 
            // btnTerminado
            // 
            this.btnTerminado.ActiveControl = null;
            this.btnTerminado.Location = new System.Drawing.Point(493, 277);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(100, 44);
            this.btnTerminado.TabIndex = 8;
            this.btnTerminado.Text = "Hecho";
            this.btnTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTerminado.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnTerminado.UseSelectable = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoProducto);
            this.groupBox1.Controls.Add(this.dataGridViewABM);
            this.groupBox1.Controls.Add(this.btnTerminado);
            this.groupBox1.Controls.Add(this.cboComponentes);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cboProductos);
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 327);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.ActiveControl = null;
            this.btnNuevoProducto.Location = new System.Drawing.Point(337, 19);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(165, 35);
            this.btnNuevoProducto.TabIndex = 10;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoProducto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNuevoProducto.UseSelectable = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // dataGridViewABM
            // 
            this.dataGridViewABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewABM.Location = new System.Drawing.Point(7, 111);
            this.dataGridViewABM.Name = "dataGridViewABM";
            this.dataGridViewABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewABM.Size = new System.Drawing.Size(586, 160);
            this.dataGridViewABM.TabIndex = 9;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM";
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.ABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboProductos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnAgregar;
        private MetroFramework.Controls.MetroTile btnEliminar;
        private MetroFramework.Controls.MetroTile btnModificar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboComponentes;
        private MetroFramework.Controls.MetroTile btnTerminado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewABM;
        private MetroFramework.Controls.MetroTile btnNuevoProducto;
    }
}