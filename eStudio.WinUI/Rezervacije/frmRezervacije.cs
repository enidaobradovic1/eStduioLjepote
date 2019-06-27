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

namespace eStudio.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService aPIService = new APIService("Rezervacija");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Rezervacija>>(null);
            dgvRezervacije.DataSource = result;


        }

       

        private async void btnPrikazi_Click_1(object sender, EventArgs e)
        {
            var search = new RezervacijeSearchRequest()
            {
                Dan=txtDan.Text,
                Mjesec=txtMjesec.Text,
                Godina= txtGodina.Text


            };
            var result = await aPIService.Get<List<eStudioLjepote.Model.Rezervacija>>(search);
            dgvRezervacije.DataSource = result;
        }

        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;
            frmRezervacijeDetalji frm = new frmRezervacijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }



        //private async void btnPrikazi_Click(object sender, EventArgs e)
        //{
        //    var search = new RezervacijeSearchRequest()
        //    {
        //        DatumRezervacije = DateTime.Parse(dateTimePicker1.Text)
        //    };

        //    var result = await aPIService.Get<List<eStudioLjepote.Model.Rezervacija>>(search);
        //    dgvRezervacije.DataSource = result;
        //}


    }
}

