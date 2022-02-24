namespace UAS_OOP_1204045
{
    partial class ViewMhs
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
            this.datamhs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datamhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Mahasiswa";
            // 
            // datamhs
            // 
            this.datamhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamhs.Location = new System.Drawing.Point(116, 104);
            this.datamhs.Name = "datamhs";
            this.datamhs.RowTemplate.Height = 25;
            this.datamhs.Size = new System.Drawing.Size(568, 309);
            this.datamhs.TabIndex = 1;
            // 
            // ViewMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datamhs);
            this.Controls.Add(this.label1);
            this.Name = "ViewMhs";
            this.Text = "ViewMhs";
            this.Load += new System.EventHandler(this.ViewMhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView datamhs;
    }
}