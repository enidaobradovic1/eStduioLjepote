namespace eStudio.WinUI.Proizvodi
{
    partial class frmProizvodiDetalji
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
            this.btnSacuvajProizvod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInserPhoto = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajProizvod
            // 
            this.btnSacuvajProizvod.Location = new System.Drawing.Point(505, 347);
            this.btnSacuvajProizvod.Name = "btnSacuvajProizvod";
            this.btnSacuvajProizvod.Size = new System.Drawing.Size(147, 29);
            this.btnSacuvajProizvod.TabIndex = 34;
            this.btnSacuvajProizvod.Text = "Sacuvaj";
            this.btnSacuvajProizvod.UseVisualStyleBackColor = true;
            this.btnSacuvajProizvod.Click += new System.EventHandler(this.btnSacuvajProizvod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(152, 192);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(112, 20);
            this.txtCijena.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Skladiste:";
            // 
            // dateTimePickerDatumKupovine
            // 
            this.dateTimePickerDatumKupovine.Location = new System.Drawing.Point(152, 232);
            this.dateTimePickerDatumKupovine.Name = "dateTimePickerDatumKupovine";
            this.dateTimePickerDatumKupovine.Size = new System.Drawing.Size(278, 20);
            this.dateTimePickerDatumKupovine.TabIndex = 29;
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Location = new System.Drawing.Point(347, 192);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.Size = new System.Drawing.Size(83, 20);
            this.txtSkladiste.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Datum kupovine:";
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(152, 160);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(278, 20);
            this.txtNazivProizvoda.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Naziv:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(152, 120);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(278, 20);
            this.txtSifra.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sifra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vrste proizvoda:";
            // 
            // comboBoxVrstaProizvoda
            // 
            this.comboBoxVrstaProizvoda.FormattingEnabled = true;
            this.comboBoxVrstaProizvoda.Location = new System.Drawing.Point(152, 76);
            this.comboBoxVrstaProizvoda.Name = "comboBoxVrstaProizvoda";
            this.comboBoxVrstaProizvoda.Size = new System.Drawing.Size(278, 21);
            this.comboBoxVrstaProizvoda.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(52, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 2);
            this.panel1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(48, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Podaci o proizvodu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInserPhoto
            // 
            this.btnInserPhoto.Location = new System.Drawing.Point(430, 264);
            this.btnInserPhoto.Name = "btnInserPhoto";
            this.btnInserPhoto.Size = new System.Drawing.Size(56, 30);
            this.btnInserPhoto.TabIndex = 42;
            this.btnInserPhoto.Text = "Dodaj";
            this.btnInserPhoto.UseVisualStyleBackColor = true;
            this.btnInserPhoto.Click += new System.EventHandler(this.btnInserPhoto_Click_1);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(146, 268);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(278, 20);
            this.txtSlika.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Slika:";
            // 
            // frmProizvodiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 403);
            this.Controls.Add(this.btnInserPhoto);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSacuvajProizvod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDatumKupovine);
            this.Controls.Add(this.txtSkladiste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazivProizvoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVrstaProizvoda);
            this.Name = "frmProizvodiDetalji";
            this.Text = "frmProizvodiDetalji";
            this.Load += new System.EventHandler(this.frmProizvodiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacuvajProizvod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumKupovine;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVrstaProizvoda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInserPhoto;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label7;
    }
}