using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Usluge
{
    public partial class frmUsluge : Form
    {
        private readonly APIService aPIService = new APIService("Usluge");

        public frmUsluge()
        {
            InitializeComponent();
        }

        private async void frmUsluge_Load(object sender, EventArgs e)
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Usluga>>(null);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = result;
        }

        private void dgvUsluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNovaUsluga_Click(object sender, EventArgs e)
        {
            frmUslugeDetalji frm = new frmUslugeDetalji();
            frm.Show();
        }

        private void dgvUsluge_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var id = dgvUsluge.SelectedRows[0].Cells[0].Value;
            frmUslugeDetalji frm = new frmUslugeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
