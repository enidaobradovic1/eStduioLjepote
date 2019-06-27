using eStudioLjepote.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
    public  class KlijentProfilViewModel:BaseViewModel
    {
        private readonly APIService service = new APIService("Klijenti");
        private readonly APIService serviceGradovi = new APIService("Gradovi");
        public KlijentProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        string ime = string.Empty;
        public string Ime
        {
            get { return ime; }
            set { SetProperty(ref ime, value); }
        }



        string prezime = string.Empty;
        public string Prezime
        {
            get { return prezime; }
            set { SetProperty(ref prezime, value); }
        }

        string brojTelefona = string.Empty;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { SetProperty(ref brojTelefona, value); }
        }

        string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }
        string grad = string.Empty;
        public string Grad
        {
            get { return grad; }
            set { SetProperty(ref grad, value); }
        }
        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        string password = string.Empty;



        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        string imePrezime = string.Empty;

        public string ImePrezime
        {
            get { return imePrezime; }
            set { SetProperty(ref imePrezime, value); }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await service.Get<List<Klijent>>(null);
            
            foreach (var klijent in list)
            {
               if(klijent.Username==APIService.Username)
                {
                    var grad = await serviceGradovi.GetById<Grad>(klijent.GradId);
                    Ime = klijent.Ime;
                    Prezime = klijent.Prezime;
                    BrojTelefona = klijent.BrojTelefona;
                    Email = klijent.Email;
                    Username = klijent.Username;
                    Grad = grad.Naziv;
                    ImePrezime = klijent.Ime + " " + klijent.Prezime;
                    
                }
            }
        }

    }
}
