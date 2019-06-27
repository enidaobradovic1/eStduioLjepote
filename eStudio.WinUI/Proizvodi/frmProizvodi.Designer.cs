namespace eStudio.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSacuvajProizvod = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnInserPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.ProizvodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVrstaProizvoda
            // 
            this.comboBoxVrstaProizvoda.FormattingEnabled = true;
            this.comboBoxVrstaProizvoda.Location = new System.Drawing.Point(218, 32);
            this.comboBoxVrstaProizvoda.Name = "comboBoxVrstaProizvoda";
            this.comboBoxVrstaProizvoda.Size = new System.Drawing.Size(278, 21);
            this.comboBoxVrstaProizvoda.TabIndex = 0;
            this.comboBoxVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaProizvoda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrste proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(218, 76);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(278, 20);
            this.txtSifra.TabIndex = 3;
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(218, 116);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(278, 20);
            this.txtNazivProizvoda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv:";
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Location = new System.Drawing.Point(413, 148);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.Size = new System.Drawing.Size(83, 20);
            this.txtSkladiste.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum kupovine:";
            // 
            // dateTimePickerDatumKupovine
            // 
            this.dateTimePickerDatumKupovine.Location = new System.Drawing.Point(218, 188);
            this.dateTimePickerDatumKupovine.Name = "dateTimePickerDatumKupovine";
            this.dateTimePickerDatumKupovine.Size = new System.Drawing.Size(278, 20);
            this.dateTimePickerDatumKupovine.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Skladiste:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(218, 148);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(112, 20);
            this.txtCijena.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cijena:";
            // 
            // btnSacuvajProizvod
            // 
            this.btnSacuvajProizvod.Location = new System.Drawing.Point(645, 277);
            this.btnSacuvajProizvod.Name = "btnSacuvajProizvod";
            this.btnSacuvajProizvod.Size = new System.Drawing.Size(129, 29);
            this.btnSacuvajProizvod.TabIndex = 16;
            this.btnSacuvajProizvod.Text = "Sacuvaj";
            this.btnSacuvajProizvod.UseVisualStyleBackColor = true;
            this.btnSacuvajProizvod.Click += new System.EventHandler(this.btnSacuvajProizvod_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Slika:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(218, 225);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(265, 20);
            this.txtSlika.TabIndex = 19;
            // 
            // btnInserPhoto
            // 
            this.btnInserPhoto.Location = new System.Drawing.Point(489, 219);
            this.btnInserPhoto.Name = "btnInserPhoto";
            this.btnInserPhoto.Size = new System.Drawing.Size(56, 30);
            this.btnInserPhoto.TabIndex = 20;
            this.btnInserPhoto.Text = "Dodaj";
            this.btnInserPhoto.UseVisualStyleBackColor = true;
            this.btnInserPhoto.Click += new System.EventHandler(this.btnInserPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(671, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 118);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProizvodi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProizvodi.BackgroundColor = System.Drawing.Color.White;
            this.dgvProizvodi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProizvodi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProizvodi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProizvodi.ColumnHeadersHeight = 50;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodId,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Skladiste,
            this.Slika});
            this.dgvProizvodi.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProizvodi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProizvodi.EnableHeadersVisualStyles = false;
            this.dgvProizvodi.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 312);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProizvodi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProizvodi.RowTemplate.Height = 40;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(804, 221);
            this.dgvProizvodi.TabIndex = 23;
            this.dgvProizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseDoubleClick_1);
            // 
            // ProizvodId
            // 
            this.ProizvodId.DataPropertyName = "ProizvodId";
            this.ProizvodId.HeaderText = "ProizvodId";
            this.ProizvodId.Name = "ProizvodId";
            this.ProizvodId.ReadOnly = true;
            this.ProizvodId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            this.Sifra.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 150;
            // 
            // Skladiste
            // 
            this.Skladiste.DataPropertyName = "KolicinaUskladiste";
            this.Skladiste.HeaderText = "Skladiste";
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            this.Skladiste.Width = 150;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 150;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 530);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInserPhoto);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSacuvajProizvod);
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
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVrstaProizvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumKupovine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvajProizvod;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnInserPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}