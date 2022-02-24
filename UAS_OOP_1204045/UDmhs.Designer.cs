namespace UAS_OOP_1204045
{
    partial class UDmhs
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
            this.DGkelolamhs = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGkelolamhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Data Mahasiswa";
            // 
            // DGkelolamhs
            // 
            this.DGkelolamhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGkelolamhs.Location = new System.Drawing.Point(108, 76);
            this.DGkelolamhs.Name = "DGkelolamhs";
            this.DGkelolamhs.RowTemplate.Height = 25;
            this.DGkelolamhs.Size = new System.Drawing.Size(566, 321);
            this.DGkelolamhs.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(247, 403);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 35);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(433, 403);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(106, 35);
            this.hapus.TabIndex = 3;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // UDmhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.update);
            this.Controls.Add(this.DGkelolamhs);
            this.Controls.Add(this.label1);
            this.Name = "UDmhs";
            this.Text = "UDmhs";
            this.Load += new System.EventHandler(this.UDmhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGkelolamhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView DGkelolamhs;
        private Button update;
        private Button hapus;
    }
}