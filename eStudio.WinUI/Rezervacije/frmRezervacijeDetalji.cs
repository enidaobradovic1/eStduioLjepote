using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;

namespace eStudio.WinUI.Rezervacije
{
    public partial class frmRezervacijeDetalji : Form
    {
        private readonly APIService aPIService = new APIService("Rezervacija");
        private readonly APIService aPIServiceUsluge = new APIService("Usluge");
        private readonly APIService aPIServiceKlijenti = new APIService("Klijenti");

        private int? _rezervacijaId;
        public frmRezervacijeDetalji(int? rezervacijaId=null)
        {
            InitializeComponent();
            _rezervacijaId = rezervacijaId;
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            if(_rezervacijaId.HasValue)
            {
                var rezervacija = await aPIService.GetById<Rezervacija>(_rezervacijaId);
                var klijent = await aPIServiceKlijenti.GetById<Klijent>(rezervacija.KlijentId);
               
               var usluga = await aPIServiceUsluge.GetById<Usluga>(rezervacija.UslugeId);
               txtUsluga.Text = usluga.Naziv;
               txtBrojOsoba.Text = rezervacija.BrojOsoba.ToString();
                 
                
                


               txtKlijent.Text = klijent.Ime + " " + klijent.Prezime;

                checkBox1.Checked = rezervacija.Prihvaceno;
            }


        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new RezervacijeUpdateRequest() {
                Prihvaceno = checkBox1.Checked
            };
            await aPIService.Update<Rezervacija>(_rezervacijaId, request);
        }
    }
}
