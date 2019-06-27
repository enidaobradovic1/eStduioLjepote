namespace eStudio.WinUI.Klijenti
{
    partial class frmKlijenti
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretragaKlijenta = new System.Windows.Forms.TextBox();
            this.btnPrikaziKlijente = new System.Windows.Forms.Button();
            this.btnNoviKlijent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Klijenti";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 50);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKlijenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlijenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKlijenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvKlijenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKlijenti.ColumnHeadersHeight = 50;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon});
            this.dgvKlijenti.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKlijenti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKlijenti.EnableHeadersVisualStyles = false;
            this.dgvKlijenti.GridColor = System.Drawing.SystemColors.Control;
            this.dgvKlijenti.Location = new System.Drawing.Point(12, 183);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlijenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKlijenti.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKlijenti.RowTemplate.Height = 40;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(1119, 318);
            this.dgvKlijenti.TabIndex = 6;
            this.dgvKlijenti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijenti_MouseDoubleClick);
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "Id";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 200;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "BrojTelefona";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 200;
            // 
            // txtPretragaKlijenta
            // 
            this.txtPretragaKlijenta.Location = new System.Drawing.Point(12, 130);
            this.txtPretragaKlijenta.Name = "txtPretragaKlijenta";
            this.txtPretragaKlijenta.Size = new System.Drawing.Size(275, 20);
            this.txtPretragaKlijenta.TabIndex = 8;
            // 
            // btnPrikaziKlijente
            // 
            this.btnPrikaziKlijente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikaziKlijente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrikaziKlijente.FlatAppearance.BorderSize = 0;
            this.btnPrikaziKlijente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikaziKlijente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPrikaziKlijente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziKlijente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrikaziKlijente.Location = new System.Drawing.Point(303, 121);
            this.btnPrikaziKlijente.Name = "btnPrikaziKlijente";
            this.btnPrikaziKlijente.Size = new System.Drawing.Size(116, 35);
            this.btnPrikaziKlijente.TabIndex = 7;
            this.btnPrikaziKlijente.Text = "Prikazi";
            this.btnPrikaziKlijente.UseVisualStyleBackColor = false;
            this.btnPrikaziKlijente.Click += new System.EventHandler(this.btnPrikaziKlijente_Click);
            // 
            // btnNoviKlijent
            // 
            this.btnNoviKlijent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoviKlijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviKlijent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviKlijent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNoviKlijent.Location = new System.Drawing.Point(460, 121);
            this.btnNoviKlijent.Name = "btnNoviKlijent";
            this.btnNoviKlijent.Size = new System.Drawing.Size(166, 35);
            this.btnNoviKlijent.TabIndex = 9;
            this.btnNoviKlijent.Text = "Novi klijent";
            this.btnNoviKlijent.UseVisualStyleBackColor = false;
            this.btnNoviKlijent.Click += new System.EventHandler(this.btnNoviKlijent_Click);
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btnNoviKlijent);
            this.Controls.Add(this.txtPretragaKlijenta);
            this.Controls.Add(this.btnPrikaziKlijente);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKlijenti";
            this.Text = "frmKlijenti";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.TextBox txtPretragaKlijenta;
        private System.Windows.Forms.Button btnPrikaziKlijente;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.Button btnNoviKlijent;
    }
}