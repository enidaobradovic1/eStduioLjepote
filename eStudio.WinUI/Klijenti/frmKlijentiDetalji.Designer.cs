namespace eStudio.WinUI.Klijenti
{
    partial class frmKlijentiDetalji
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxGradovi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefonKlijenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailKlijentra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSPol = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtPrezimeKlijenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeKlijenta = new System.Windows.Forms.TextBox();
            this.btnSnimiKlijenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPotvrdaKlijenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordKlijenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKorisnickoImeKlijenta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGradovi
            // 
            this.comboBoxGradovi.FormattingEnabled = true;
            this.comboBoxGradovi.Location = new System.Drawing.Point(338, 136);
            this.comboBoxGradovi.Name = "comboBoxGradovi";
            this.comboBoxGradovi.Size = new System.Drawing.Size(174, 21);
            this.comboBoxGradovi.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Grad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Telefon:";
            // 
            // txtTelefonKlijenta
            // 
            this.txtTelefonKlijenta.Location = new System.Drawing.Point(337, 180);
            this.txtTelefonKlijenta.Name = "txtTelefonKlijenta";
            this.txtTelefonKlijenta.Size = new System.Drawing.Size(171, 20);
            this.txtTelefonKlijenta.TabIndex = 57;
            this.txtTelefonKlijenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefonKlijenta_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Email:";
            // 
            // txtEmailKlijentra
            // 
            this.txtEmailKlijentra.Location = new System.Drawing.Point(106, 183);
            this.txtEmailKlijentra.Name = "txtEmailKlijentra";
            this.txtEmailKlijentra.Size = new System.Drawing.Size(159, 20);
            this.txtEmailKlijentra.TabIndex = 52;
            this.txtEmailKlijentra.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailKlijentra_Validating);
            this.txtEmailKlijentra.Validated += new System.EventHandler(this.txtEmailKlijentra_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(59, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Spol:";
            // 
            // txtSPol
            // 
            this.txtSPol.Location = new System.Drawing.Point(106, 144);
            this.txtSPol.Name = "txtSPol";
            this.txtSPol.Size = new System.Drawing.Size(159, 20);
            this.txtSPol.TabIndex = 47;
            this.txtSPol.Validating += new System.ComponentModel.CancelEventHandler(this.txtSPol_Validating);
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(281, 96);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(47, 13);
            this.Prezime.TabIndex = 46;
            this.Prezime.Text = "Prezime:";
            // 
            // txtPrezimeKlijenta
            // 
            this.txtPrezimeKlijenta.Location = new System.Drawing.Point(338, 96);
            this.txtPrezimeKlijenta.Name = "txtPrezimeKlijenta";
            this.txtPrezimeKlijenta.Size = new System.Drawing.Size(171, 20);
            this.txtPrezimeKlijenta.TabIndex = 45;
            this.txtPrezimeKlijenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezimeKlijenta_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Licni podaci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ime: ";
            // 
            // txtImeKlijenta
            // 
            this.txtImeKlijenta.Location = new System.Drawing.Point(106, 96);
            this.txtImeKlijenta.Name = "txtImeKlijenta";
            this.txtImeKlijenta.Size = new System.Drawing.Size(159, 20);
            this.txtImeKlijenta.TabIndex = 42;
            this.txtImeKlijenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeKlijenta_Validating);
            // 
            // btnSnimiKlijenta
            // 
            this.btnSnimiKlijenta.Location = new System.Drawing.Point(367, 410);
            this.btnSnimiKlijenta.Name = "btnSnimiKlijenta";
            this.btnSnimiKlijenta.Size = new System.Drawing.Size(145, 23);
            this.btnSnimiKlijenta.TabIndex = 70;
            this.btnSnimiKlijenta.Text = "Sacuvaj";
            this.btnSnimiKlijenta.UseVisualStyleBackColor = true;
            this.btnSnimiKlijenta.Click += new System.EventHandler(this.btnSnimiKlijenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Potvrda";
            // 
            // txtPotvrdaKlijenta
            // 
            this.txtPotvrdaKlijenta.Location = new System.Drawing.Point(341, 368);
            this.txtPotvrdaKlijenta.Name = "txtPotvrdaKlijenta";
            this.txtPotvrdaKlijenta.Size = new System.Drawing.Size(171, 20);
            this.txtPotvrdaKlijenta.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Password";
            // 
            // txtPasswordKlijenta
            // 
            this.txtPasswordKlijenta.Location = new System.Drawing.Point(341, 326);
            this.txtPasswordKlijenta.Name = "txtPasswordKlijenta";
            this.txtPasswordKlijenta.Size = new System.Drawing.Size(171, 20);
            this.txtPasswordKlijenta.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Username";
            // 
            // txtKorisnickoImeKlijenta
            // 
            this.txtKorisnickoImeKlijenta.Location = new System.Drawing.Point(117, 326);
            this.txtKorisnickoImeKlijenta.Name = "txtKorisnickoImeKlijenta";
            this.txtKorisnickoImeKlijenta.Size = new System.Drawing.Size(159, 20);
            this.txtKorisnickoImeKlijenta.TabIndex = 64;
            this.txtKorisnickoImeKlijenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoImeKlijenta_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(59, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 2);
            this.panel2.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(55, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 62;
            this.label5.Text = "Kontakt podaci";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKlijentiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.btnSnimiKlijenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPotvrdaKlijenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPasswordKlijenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKorisnickoImeKlijenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGradovi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefonKlijenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmailKlijentra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSPol);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtPrezimeKlijenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeKlijenta);
            this.Name = "frmKlijentiDetalji";
            this.Text = "frmKlijentiDetalji";
            this.Load += new System.EventHandler(this.frmKlijentiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGradovi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefonKlijenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailKlijentra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSPol;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtPrezimeKlijenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeKlijenta;
        private System.Windows.Forms.Button btnSnimiKlijenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPotvrdaKlijenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordKlijenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKorisnickoImeKlijenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}