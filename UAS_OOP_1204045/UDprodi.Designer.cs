namespace UAS_OOP_1204045
{
    partial class UDprodi
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGprodi = new System.Windows.Forms.DataGridView();
            this.updateprodi = new System.Windows.Forms.Button();
            this.hapusprodi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGprodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Data Prodi";
            // 
            // DGprodi
            // 
            this.DGprodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGprodi.Location = new System.Drawing.Point(86, 75);
            this.DGprodi.Name = "DGprodi";
            this.DGprodi.RowTemplate.Height = 25;
            this.DGprodi.Size = new System.Drawing.Size(629, 303);
            this.DGprodi.TabIndex = 1;
            // 
            // updateprodi
            // 
            this.updateprodi.Location = new System.Drawing.Point(259, 403);
            this.updateprodi.Name = "updateprodi";
            this.updateprodi.Size = new System.Drawing.Size(95, 35);
            this.updateprodi.TabIndex = 2;
            this.updateprodi.Text = "Update";
            this.updateprodi.UseVisualStyleBackColor = true;
            this.updateprodi.Click += new System.EventHandler(this.updateprodi_Click);
            // 
            // hapusprodi
            // 
            this.hapusprodi.Location = new System.Drawing.Point(449, 403);
            this.hapusprodi.Name = "hapusprodi";
            this.hapusprodi.Size = new System.Drawing.Size(95, 35);
            this.hapusprodi.TabIndex = 3;
            this.hapusprodi.Text = "Hapus";
            this.hapusprodi.UseVisualStyleBackColor = true;
            this.hapusprodi.Click += new System.EventHandler(this.hapusprodi_Click);
            // 
            // UDprodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hapusprodi);
            this.Controls.Add(this.updateprodi);
            this.Controls.Add(this.DGprodi);
            this.Controls.Add(this.label1);
            this.Name = "UDprodi";
            this.Text = "UDprodi";
            this.Load += new System.EventHandler(this.UDprodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGprodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView DGprodi;
        private Button updateprodi;
        private Button hapusprodi;
    }
}