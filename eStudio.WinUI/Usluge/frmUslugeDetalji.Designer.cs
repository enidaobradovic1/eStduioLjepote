namespace eStudio.WinUI.Usluge
{
    partial class frmUslugeDetalji
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
            this.btnInserPhoto = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvajUslugu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserPhoto
            // 
            this.btnInserPhoto.Location = new System.Drawing.Point(353, 244);
            this.btnInserPhoto.Name = "btnInserPhoto";
            this.btnInserPhoto.Size = new System.Drawing.Size(56, 30);
            this.btnInserPhoto.TabIndex = 35;
            this.btnInserPhoto.Text = "Dodaj";
            this.btnInserPhoto.UseVisualStyleBackColor = true;
            this.btnInserPhoto.Click += new System.EventHandler(this.btnInserPhoto_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(118, 250);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(219, 20);
            this.txtSlika.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Slika:";
            // 
            // btnSacuvajUslugu
            // 
            this.btnSacuvajUslugu.Location = new System.Drawing.Point(172, 365);
            this.btnSacuvajUslugu.Name = "btnSacuvajUslugu";
            this.btnSacuvajUslugu.Size = new System.Drawing.Size(129, 29);
            this.btnSacuvajUslugu.TabIndex = 32;
            this.btnSacuvajUslugu.Text = "Sacuvaj";
            this.btnSacuvajUslugu.UseVisualStyleBackColor = true;
            this.btnSacuvajUslugu.Click += new System.EventHandler(this.btnSacuvajUslugu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(639, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(118, 198);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(219, 20);
            this.txtCijena.TabIndex = 30;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(118, 33);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(219, 20);
            this.txtNaziv.TabIndex = 22;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Naziv:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(118, 73);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(219, 96);
            this.txtOpis.TabIndex = 36;
            this.txtOpis.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUslugeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnInserPhoto);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSacuvajUslugu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Name = "frmUslugeDetalji";
            this.Text = "frmUslugeDetalji";
            this.Load += new System.EventHandler(this.frmUslugeDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserPhoto;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvajUslugu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}