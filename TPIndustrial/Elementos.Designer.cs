namespace Industrial2
{
    partial class Elementos
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
            this.dataGridViewElementos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewElementos
            // 
            this.dataGridViewElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElementos.Location = new System.Drawing.Point(22, 78);
            this.dataGridViewElementos.Name = "dataGridViewElementos";
            this.dataGridViewElementos.RowTemplate.Height = 24;
            this.dataGridViewElementos.Size = new System.Drawing.Size(280, 448);
            this.dataGridViewElementos.TabIndex = 0;
            // 
            // Elementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 554);
            this.Controls.Add(this.dataGridViewElementos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Elementos";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Elementos";
            this.Load += new System.EventHandler(this.Elementos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewElementos;
    }
}