using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eStudioLjepote.Model.Requests;

namespace eStudio.WinUI.Zaposlenici
{
    public partial class frmZaposlenici : Form
    {
        private readonly APIService aPIService = new APIService("Zaposlenici");
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposleniciSearchRequest() {
                Ime = txtPretraga.Text
            };
            var result = await aPIService.Get<List<eStudioLjepote.Model.Zaposlenik>>(search);
            dgvZaposlenici.AutoGenerateColumns = false;



            
            dgvZaposlenici.DataSource = result;

        }

        private async void frmZaposlenici_Load(object sender, EventArgs e)
        {
        
          

            var result = await aPIService.Get<List<eStudioLjepote.Model.Zaposlenik>>(null);
            dgvZaposlenici.AutoGenerateColumns = false;




            dgvZaposlenici.DataSource = result;


        }
        private async void btnObrisi_click(object sender, EventArgs e)
        {
            var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;
           
        }

      

        private void dgvZaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private  void dgvZaposlenici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;
            frmZaposleniciDetalji frm = new frmZaposleniciDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        

        private void btnNoviZaposlenik_Click_1(object sender, EventArgs e)
        {
            frmZaposleniciDetalji frm = new frmZaposleniciDetalji();
            frm.Show();
        }
    }
}
