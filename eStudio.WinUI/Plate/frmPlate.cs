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
    public partial class frmPlate : Form
    {
        private readonly APIService aPIService = new APIService("Plate");

        public frmPlate()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new PlataSearchRequest()
            {
                Mjesec = txtMjesec.Text,
                Godina = txtGodina.Text
            };
            var result = await aPIService.Get<List<eStudioLjepote.Model.Plata>>(search);
            dgvplate.DataSource = result;
        }

        private async void frmPlate_Load(object sender, EventArgs e)
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Plata>>(null);
            dgvplate.DataSource = result;
        }

        private void dgvplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvplate.SelectedRows[0].Cells[0].Value;
            frmPlataDetalji frm = new frmPlataDetalji(int.Parse(id.ToString()));
            frm.Show();

        }

        private void btnNovaplata_Click(object sender, EventArgs e)
        {
            frmPlataDetalji frm = new frmPlataDetalji();
            frm.Show();
        }
    }
}
