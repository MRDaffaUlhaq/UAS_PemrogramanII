namespace UAS_OOP_1204045
{
    partial class mahasiswa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.submitmhs = new System.Windows.Forms.Button();
            this.npmTB = new System.Windows.Forms.TextBox();
            this.namamhs = new System.Windows.Forms.TextBox();
            this.prodicombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(247, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(247, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Program Studi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(386, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(386, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(386, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(422, 332);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(99, 37);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // submitmhs
            // 
            this.submitmhs.Location = new System.Drawing.Point(297, 332);
            this.submitmhs.Name = "submitmhs";
            this.submitmhs.Size = new System.Drawing.Size(95, 37);
            this.submitmhs.TabIndex = 8;
            this.submitmhs.Text = "Submit";
            this.submitmhs.UseVisualStyleBackColor = true;
            this.submitmhs.Click += new System.EventHandler(this.submitmhs_Click_1);
            // 
            // npmTB
            // 
            this.npmTB.Location = new System.Drawing.Point(406, 146);
            this.npmTB.Name = "npmTB";
            this.npmTB.Size = new System.Drawing.Size(145, 23);
            this.npmTB.TabIndex = 9;
            // 
            // namamhs
            // 
            this.namamhs.Location = new System.Drawing.Point(406, 193);
            this.namamhs.Name = "namamhs";
            this.namamhs.Size = new System.Drawing.Size(235, 23);
            this.namamhs.TabIndex = 10;
            // 
            // prodicombobox
            // 
            this.prodicombobox.FormattingEnabled = true;
            this.prodicombobox.Location = new System.Drawing.Point(406, 246);
            this.prodicombobox.Name = "prodicombobox";
            this.prodicombobox.Size = new System.Drawing.Size(235, 23);
            this.prodicombobox.TabIndex = 11;
            this.prodicombobox.SelectedIndexChanged += new System.EventHandler(this.prodicombobox_SelectedIndexChanged);
            // 
            // mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodicombobox);
            this.Controls.Add(this.namamhs);
            this.Controls.Add(this.npmTB);
            this.Controls.Add(this.submitmhs);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mahasiswa";
            this.Text = "mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button clear;
        private Button submitmhs;
        private TextBox npmTB;
        private TextBox namamhs;
        private ComboBox prodicombobox;
    }
}