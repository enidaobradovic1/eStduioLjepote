using eStudioLjepote.Model;
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

namespace eStudio.WinUI.Zaposlenici
{
    public partial class frmZaposleniciDetalji : Form
    {
        private  int? _zaposlenikId;
        private readonly APIService aPIServiceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService aPIServiceGradovi = new APIService("Gradovi");
        private readonly APIService aPIServiceUloge = new APIService("Uloge");


        public frmZaposleniciDetalji(int? zaposlenikId=null)
        {
            InitializeComponent();
            _zaposlenikId = zaposlenikId;
        }

        private void frmZaposleniciDetalji_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void frmZaposleniciDetalji_Load(object sender, EventArgs e)
        {

            var gradovi = await aPIServiceGradovi.Get<List<eStudioLjepote.Model.Grad>>(null);


           
            comboBoxGradovi.DisplayMember = "Naziv";
            comboBoxGradovi.ValueMember = "Id";
            comboBoxGradovi.DataSource = gradovi;

            var uloge = await aPIServiceUloge.Get<List<eStudioLjepote.Model.Uloge>>(null);

            clbUloge.DataSource = uloge;
            clbUloge.DisplayMember = "Naziv";




            if (_zaposlenikId.HasValue)
            {
                var zaposlenik = await aPIServiceZaposlenici.GetById<eStudioLjepote.Model.Zaposlenik>(_zaposlenikId);
                var grad= await aPIServiceGradovi.GetById<eStudioLjepote.Model.Grad>(zaposlenik.GradId);
                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Text = zaposlenik.Email;
                txtJMBG.Text = zaposlenik.Jmbg;
                txtTelefon.Text = zaposlenik.BrojTelefona;
                txtKorisnickoIme.Text = zaposlenik.Username;
                dateTimePickerDatumRodjenja.Text = zaposlenik.DatumRodjenja.ToShortDateString();
                dateTimePickerDatumZaposlenja.Text = zaposlenik.DatumZaposelenja.ToShortDateString();
                comboBoxGradovi.Text = grad.Naziv;
                foreach(var role in zaposlenik.ZaposleniciUloge)
                {
                    for(int i=0;i<clbUloge.Items.Count;i++)
                    {
                        if (((Uloge)clbUloge.Items[i]).Naziv == role.Uloga.Naziv)
                            clbUloge.SetItemChecked(i, true);
                    }
                }
               

            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var roleList = clbUloge.CheckedItems.Cast<eStudioLjepote.Model.Uloge>().Select(x => x.Id).ToList();
                var request = new ZaposleniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Jmbg = txtJMBG.Text,
                    BrojTelefona = txtTelefon.Text,
                    Username = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    DatumRodjenja = DateTime.Parse(dateTimePickerDatumRodjenja.Text),
                    DatumZaposelenja = DateTime.Parse(dateTimePickerDatumZaposlenja.Text),
                    GradId = (int)comboBoxGradovi.SelectedValue,
                    Uloge=roleList

                };
                if (_zaposlenikId.HasValue)
                {
                    await aPIServiceZaposlenici.Update<eStudioLjepote.Model.Zaposlenik>(_zaposlenikId, request);
                }
                else
                {
                    await aPIServiceZaposlenici.Insert<eStudioLjepote.Model.Zaposlenik>(request);
                }
                MessageBox.Show("Operacija uspjesna.");
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text)&& txtIme.Text.Length<4)
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel=true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text)&& txtPrezime.Text.Length<4)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                errorProvider.SetError(txtJMBG, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtJMBG, null);
            }
        }

        
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text)&& txtKorisnickoIme.Text.Length<4)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
