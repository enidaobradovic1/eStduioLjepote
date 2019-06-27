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

namespace eStudio.WinUI.Plate
{
    public partial class frmPlataDetalji : Form
    {
        private int? _plataId;
        private readonly APIService aPIServicePlate = new APIService("Plate");
        private readonly APIService aPIServiceZaposlenici = new APIService("Zaposlenici");
        public frmPlataDetalji(int? plataId = null)
        {
            InitializeComponent();
            _plataId = plataId;
        }
        private async Task Zaposlenici_Load()
        {
            var result = await aPIServiceZaposlenici.Get<List<eStudioLjepote.Model.Zaposlenik>>(null);
            result.Insert(0, new eStudioLjepote.Model.Zaposlenik());
            comboBoxZaposlenici.DataSource = result;

            comboBoxZaposlenici.DisplayMember = "FullName";
            comboBoxZaposlenici.ValueMember = "Id";
        }

        private async void  frmPlataDetalji_Load(object sender, EventArgs e)
        {
            await Zaposlenici_Load();
            if (_plataId.HasValue)
            {
                var plata = await aPIServicePlate.GetById<eStudioLjepote.Model.Plata>(_plataId);
                var zaposlenik = await aPIServiceZaposlenici.GetById<eStudioLjepote.Model.Zaposlenik>(plata.ZaposlenikId);
                txtIznos.Text = plata.Iznos.ToString();
                dateTimePicker1.Text = plata.Datum.ToString();
                comboBoxZaposlenici.SelectedValue = plata.ZaposlenikId;
                txtGodina.Text = plata.Godina.ToString();
                txtMjesec.Text = plata.Mjesec.ToString();


            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new PlataUpsertRequest()
            {

                ZaposlenikId = (int)comboBoxZaposlenici.SelectedValue,
                Datum = DateTime.Parse(dateTimePicker1.Text),

                Iznos = decimal.Parse(txtIznos.Text),
                Godina = int.Parse(txtGodina.Text),
                Mjesec=int.Parse(txtMjesec.Text)
            };
            if (_plataId.HasValue)
            {
                await aPIServicePlate.Update<eStudioLjepote.Model.Plata>(_plataId, request);
            }
            else
            {
                await aPIServicePlate.Insert<eStudioLjepote.Model.Plata>(request);
            }
            MessageBox.Show("Operacija uspjesna.");

        }

        private void txtGodina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGodina.Text))
            {
                errorProvider1.SetError(txtGodina, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodina, null);
            }
        }

        private void txtMjesec_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjesec.Text))
            {
                errorProvider1.SetError(txtMjesec, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMjesec, null);
            }
        }

        private void txtIznos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                errorProvider1.SetError(txtIznos, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIznos, null);
            }
        }
    }
}
