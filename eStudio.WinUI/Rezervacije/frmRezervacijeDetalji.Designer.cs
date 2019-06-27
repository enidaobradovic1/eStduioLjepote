namespace eStudio.WinUI.Rezervacije
{
    partial class frmRezervacijeDetalji
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
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsluga = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj osoba: ";
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Enabled = false;
            this.txtBrojOsoba.Location = new System.Drawing.Point(91, 78);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.Size = new System.Drawing.Size(245, 20);
            this.txtBrojOsoba.TabIndex = 1;
            // 
            // txtKlijent
            // 
            this.txtKlijent.Enabled = false;
            this.txtKlijent.Location = new System.Drawing.Point(91, 118);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(245, 20);
            this.txtKlijent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klijent: ";
            // 
            // txtUsluga
            // 
            this.txtUsluga.Enabled = false;
            this.txtUsluga.Location = new System.Drawing.Point(93, 153);
            this.txtUsluga.Name = "txtUsluga";
            this.txtUsluga.Size = new System.Drawing.Size(243, 20);
            this.txtUsluga.TabIndex = 5;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(44, 153);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(43, 13);
            this.txt.TabIndex = 4;
            this.txt.Text = "Usluga:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Prihvati";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(140, 251);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Prihvati";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 2);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Podaci o rezervaciji";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(14, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 2);
            this.panel2.TabIndex = 14;
            // 
            // frmRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtUsluga);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.label1);
            this.Name = "frmRezervacijeDetalji";
            this.Text = "frmRezervacijeDetalji";
            this.Load += new System.EventHandler(this.frmRezervacijeDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsluga;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}