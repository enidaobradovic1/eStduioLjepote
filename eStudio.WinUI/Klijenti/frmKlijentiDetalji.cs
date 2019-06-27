using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        private int? _klijentId;
        private readonly APIService aPIServiceKlijenti = new APIService("Klijenti");
        private readonly APIService aPIServiceGradovi = new APIService("Gradovi");
        public frmKlijentiDetalji(int? klijentId = null)
        {
            InitializeComponent();
            _klijentId = klijentId;
        }

        private async void frmKlijentiDetalji_Load(object sender, EventArgs e)
        {
            var gradovi = await aPIServiceGradovi.Get<List<eStudioLjepote.Model.Grad>>(null);



            comboBoxGradovi.DisplayMember = "Naziv";
            comboBoxGradovi.ValueMember = "Id";
            comboBoxGradovi.DataSource = gradovi;

            if (_klijentId.HasValue)
            {
                var klijent = await aPIServiceKlijenti.GetById<eStudioLjepote.Model.Klijent>(_klijentId);
                var grad = await aPIServiceGradovi.GetById<eStudioLjepote.Model.Grad>(klijent.GradId);
                txtImeKlijenta.Text = klijent.Ime;
                txtPrezimeKlijenta.Text = klijent.Prezime;
                txtEmailKlijentra.Text = klijent.Email;
                txtSPol.Text = klijent.Spol;
              


                txtTelefonKlijenta.Text = klijent.BrojTelefona;
                txtKorisnickoImeKlijenta.Text = klijent.Username;
               
                comboBoxGradovi.Text = grad.Naziv;

            }


        }

        private async void btnSnimiKlijenta_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KlijentiUpsertRequest()
                {
                    Ime = txtImeKlijenta.Text,
                    Prezime = txtPrezimeKlijenta.Text,
                    Email = txtEmailKlijentra.Text,

                    BrojTelefona = txtTelefonKlijenta.Text,
                    Username = txtKorisnickoImeKlijenta.Text,
                    Password = txtPasswordKlijenta.Text,
                    PasswordConfirmation = txtPotvrdaKlijenta.Text,
                    Spol = txtSPol.Text,
                    GradId = (int)comboBoxGradovi.SelectedValue,


                };
                if (_klijentId.HasValue)
                {
                    await aPIServiceKlijenti.Update<eStudioLjepote.Model.Klijent>(_klijentId, request);
                }
                else
                {
                    await aPIServiceKlijenti.Insert<eStudioLjepote.Model.Klijent>(request);
                }
                MessageBox.Show("Operacija uspjesna.");
            }
        }

        private void txtImeKlijenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeKlijenta.Text) && txtImeKlijenta.Text.Length < 4)
            {
                errorProvider1.SetError(txtImeKlijenta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtImeKlijenta, null);
            }
        }

        private void txtPrezimeKlijenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezimeKlijenta.Text) && txtPrezimeKlijenta.Text.Length < 4)
            {
                errorProvider1.SetError(txtPrezimeKlijenta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezimeKlijenta, null);
            }
        }

        private void txtSPol_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSPol.Text))
            {
                errorProvider1.SetError(txtSPol, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSPol, null);
            }
        }

        private void txtEmailKlijentra_Validated(object sender, EventArgs e)
        {

        }

        private void txtEmailKlijentra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailKlijentra.Text))
            {
                errorProvider1.SetError(txtEmailKlijentra, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmailKlijentra, null);
            }
        }

        private void txtTelefonKlijenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonKlijenta.Text))
            {
                errorProvider1.SetError(txtTelefonKlijenta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefonKlijenta, null);
            }
        }

        private void txtKorisnickoImeKlijenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoImeKlijenta.Text) && txtKorisnickoImeKlijenta.Text.Length < 4)
            {
                errorProvider1.SetError(txtKorisnickoImeKlijenta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoImeKlijenta, null);
            }
        }
    }
}
