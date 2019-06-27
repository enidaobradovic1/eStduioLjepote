namespace eStudio.WinUI.Plate
{
    partial class frmPlate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMjesec = new System.Windows.Forms.TextBox();
            this.btnNovaplata = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvplate = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 50);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Godina";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(187, 119);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(55, 20);
            this.txtGodina.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mjesec";
            // 
            // txtMjesec
            // 
            this.txtMjesec.Location = new System.Drawing.Point(76, 119);
            this.txtMjesec.Name = "txtMjesec";
            this.txtMjesec.Size = new System.Drawing.Size(48, 20);
            this.txtMjesec.TabIndex = 24;
            // 
            // btnNovaplata
            // 
            this.btnNovaplata.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNovaplata.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovaplata.FlatAppearance.BorderSize = 0;
            this.btnNovaplata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNovaplata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnNovaplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaplata.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovaplata.Location = new System.Drawing.Point(376, 111);
            this.btnNovaplata.Name = "btnNovaplata";
            this.btnNovaplata.Size = new System.Drawing.Size(116, 35);
            this.btnNovaplata.TabIndex = 23;
            this.btnNovaplata.Text = "Nova plata";
            this.btnNovaplata.UseVisualStyleBackColor = false;
            this.btnNovaplata.Click += new System.EventHandler(this.btnNovaplata_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrikazi.Location = new System.Drawing.Point(259, 111);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(84, 35);
            this.btnPrikazi.TabIndex = 22;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvplate
            // 
            this.dgvplate.AllowUserToAddRows = false;
            this.dgvplate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvplate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvplate.BackgroundColor = System.Drawing.Color.White;
            this.dgvplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvplate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvplate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvplate.ColumnHeadersHeight = 50;
            this.dgvplate.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvplate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvplate.EnableHeadersVisualStyles = false;
            this.dgvplate.GridColor = System.Drawing.SystemColors.Control;
            this.dgvplate.Location = new System.Drawing.Point(19, 188);
            this.dgvplate.Name = "dgvplate";
            this.dgvplate.ReadOnly = true;
            this.dgvplate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplate.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvplate.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvplate.RowTemplate.Height = 40;
            this.dgvplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvplate.Size = new System.Drawing.Size(914, 318);
            this.dgvplate.TabIndex = 28;
            this.dgvplate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvplate_MouseDoubleClick);
            // 
            // frmPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 575);
            this.ControlBox = false;
            this.Controls.Add(this.dgvplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMjesec);
            this.Controls.Add(this.btnNovaplata);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlate";
            this.Text = "frmPlate";
            this.Load += new System.EventHandler(this.frmPlate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMjesec;
        private System.Windows.Forms.Button btnNovaplata;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvplate;
    }
}