using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Usluge
{
    public partial class frmUslugeDetalji : Form
    {
        private int? _uslugaId;
        private readonly APIService aPIServiceUsluge = new APIService("Usluge");

        public frmUslugeDetalji(int? uslugaId=null)
        {
            InitializeComponent();
            _uslugaId = uslugaId;
        }

        private async void frmUslugeDetalji_Load(object sender, EventArgs e)
        {
            if (_uslugaId.HasValue)
            {
                var usluga = await aPIServiceUsluge.GetById<eStudioLjepote.Model.Usluga>(_uslugaId);

                txtNaziv.Text = usluga.Naziv;
                txtOpis.Text = usluga.Opis;
                txtCijena.Text = usluga.Cijena.ToString();
                MemoryStream memoryStream = new MemoryStream(usluga.Slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
                request.Slika = usluga.Slika;



            }
        }


        UslugeUpsertRequest request = new UslugeUpsertRequest();

        private async void btnSacuvajUslugu_Click(object sender, EventArgs e)
        {

            request.Naziv = txtNaziv.Text;
            request.Cijena = float.Parse(txtCijena.Text);
            request.Opis = txtOpis.Text;
            if (_uslugaId.HasValue)
            {
                await aPIServiceUsluge.Update<eStudioLjepote.Model.Usluga>(_uslugaId, request);
            }
            else
            {
                await aPIServiceUsluge.Insert<eStudioLjepote.Model.Usluga>(request);
            }
            MessageBox.Show("Operacija uspjesna.");
        }
        private void btnInserPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }
    }
}
