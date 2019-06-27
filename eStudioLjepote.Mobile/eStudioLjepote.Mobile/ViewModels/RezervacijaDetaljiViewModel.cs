using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
   public   class RezervacijaDetaljiViewModel:BaseViewModel
    {
        
        private readonly APIService service = new APIService("Rezervacija");
        private readonly APIService uslugeService = new APIService("Usluge");


        public int RezervacijaID { get; set; }
        public RezervacijaDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
         //   OtkaziCommand = new Command(async () => await Otkazi());
        }

        

        public ICommand InitCommand { get; set; }
        public ICommand OtkaziCommand { get; set; }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        string status = string.Empty;
        public string Status
        {
            get { return status; }
            set { SetProperty(ref status, value); }
        }

        public async Task Init()
        {
            var rezervacija = await service.GetById<Rezervacija>(RezervacijaID);
            var usluga = await uslugeService.GetById<Usluga>(rezervacija.UslugeId);
            Naziv = usluga.Naziv;
            if(rezervacija.Prihvaceno==true)
            {
                Status = "Prihvaceno";
            }
            else
            {
                Status = "Odbijena";
            }

        }
      

    }
}
