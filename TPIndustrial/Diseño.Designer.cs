namespace Industrial2
{
    partial class Diseño
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
            this.DataGridViewDiseño = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiseño)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewDiseño
            // 
            this.DataGridViewDiseño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDiseño.Location = new System.Drawing.Point(31, 78);
            this.DataGridViewDiseño.Name = "DataGridViewDiseño";
            this.DataGridViewDiseño.RowTemplate.Height = 24;
            this.DataGridViewDiseño.Size = new System.Drawing.Size(265, 562);
            this.DataGridViewDiseño.TabIndex = 0;
            // 
            // Diseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 668);
            this.Controls.Add(this.DataGridViewDiseño);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Diseño";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Diseño";
            this.Load += new System.EventHandler(this.Diseño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiseño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewDiseño;
    }
}