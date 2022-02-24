namespace UAS_OOP_1204045
{
    partial class datadaftarulang
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
            this.DGdaftarulang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGdaftarulang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Daftar Ulang Mahasiswa";
            // 
            // DGdaftarulang
            // 
            this.DGdaftarulang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdaftarulang.Location = new System.Drawing.Point(99, 86);
            this.DGdaftarulang.Name = "DGdaftarulang";
            this.DGdaftarulang.RowTemplate.Height = 25;
            this.DGdaftarulang.Size = new System.Drawing.Size(602, 327);
            this.DGdaftarulang.TabIndex = 1;
            // 
            // datadaftarulang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGdaftarulang);
            this.Controls.Add(this.label1);
            this.Name = "datadaftarulang";
            this.Text = "datadaftarulang";
            this.Load += new System.EventHandler(this.datadaftarulang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGdaftarulang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView DGdaftarulang;
    }
}