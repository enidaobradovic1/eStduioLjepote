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
    public partial class frmKlijenti : Form
    {
        private readonly APIService aPIService = new APIService("Klijenti");

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnPrikaziKlijente_Click(object sender, EventArgs e)
        {
            var search = new KlijentiSearchRequest()
            {
                Ime = txtPretragaKlijenta.Text
            };
            var result = await aPIService.Get<List<eStudioLjepote.Model.Klijent>>(search);
            dgvKlijenti.AutoGenerateColumns = false;



          
            dgvKlijenti.DataSource = result;
        }

        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
           
            var result = await aPIService.Get<List<eStudioLjepote.Model.Klijent>>(null);
            dgvKlijenti.AutoGenerateColumns = false;


        }
      

        private void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            frmKlijentiDetalji frm = new frmKlijentiDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnNoviKlijent_Click(object sender, EventArgs e)
        {
            frmKlijentiDetalji frm = new frmKlijentiDetalji();
            frm.Show();
        }
    }
}
