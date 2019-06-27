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

namespace eStudio.WinUI.Uplate
{
    public partial class frmUplateDetalji : Form
    {
        private int? _uplataId;
        private readonly APIService aPIServiceUplate = new APIService("Uplate");
        private readonly APIService aPIServiceTipoviUplata = new APIService("TipoviUplate");
        public frmUplateDetalji(int? uplataId=null)
        {
            InitializeComponent();
            _uplataId = uplataId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new UplateUpsertRequest()
            {

                TipUplateId = (int)comboBoxTipoviUplata.SelectedValue,
                DatumUplate = DateTime.Parse(dateTimePicker1.Text),
                RezervacijaId = int.Parse(txtRezervacija.Text),
                Iznos = float.Parse(txtIznos.Text),
                 Popust=float.Parse(txtPopust.Text),
                 ZaposlenikId=Global.LoggedUser.Id

            };
            if (_uplataId.HasValue)
            {
                await aPIServiceUplate.Update<eStudioLjepote.Model.Uplate>(_uplataId, request);
            }
            else
            {
                await aPIServiceUplate.Insert<eStudioLjepote.Model.Uplate>(request);
            }
            MessageBox.Show("Operacija uspjesna.");
        }

        private async void frmUplateDetalji_Load(object sender, EventArgs e)
        {
            var tipoviUplata = await aPIServiceTipoviUplata.Get<List<eStudioLjepote.Model.TipUplate>>(null);



            comboBoxTipoviUplata.DisplayMember = "Naziv";
            comboBoxTipoviUplata.ValueMember = "Id";
            comboBoxTipoviUplata.DataSource = tipoviUplata;




            if (_uplataId.HasValue)
            {
                var uplata = await aPIServiceUplate.GetById<eStudioLjepote.Model.Uplate>(_uplataId);
                var tipUplate = await aPIServiceTipoviUplata.GetById<eStudioLjepote.Model.TipUplate>(uplata.TipUplateId);
                txtIznos.Text = uplata.Iznos.ToString();
                dateTimePicker1.Text = uplata.DatumUplate.ToString();
                txtPopust.Text = uplata.Popust.ToString();
                txtRezervacija.Text = uplata.RezervacijaId.ToString();
                comboBoxTipoviUplata.Text = tipUplate.Naziv;

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

        private void txtPopust_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPopust.Text))
            {
                errorProvider1.SetError(txtPopust, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPopust, null);
            }
        }
    }
}
