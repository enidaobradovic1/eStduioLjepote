using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
    public   class UslugeDeljatiViewModel:BaseViewModel
    {

        private int Id;
        private readonly APIService service = new APIService("Usluge");
        private readonly APIService Ocjeneservice = new APIService("Ocjene");

        public int UslugaID { get; set; }
        public UslugeDeljatiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            
        }
        public ICommand InitCommand { get; set; }
        public ICommand RateCommand { get; set; }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        string _Opis = string.Empty;
        public string Opis
        {
            get { return _Opis; }
            set { SetProperty(ref _Opis, value); }
        }

        float _cijena = 0;
        public float Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        int _ocjena = 0;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();
        public async Task Init()
        {
            var usluga = await service.GetById<Usluga>(UslugaID);
            OcjeneSearchRequest ocjeneSearchRequest = new OcjeneSearchRequest() {
                UslugeId = UslugaID,
                KlijentId = 1
            };
            var ocjene = await Ocjeneservice.Get<List<Ocjene>>(ocjeneSearchRequest);
            
           foreach(var ocjena in ocjene)
            {
                if (ocjena != null)
                {
                    Ocjena = ocjena.Rating1;
                }
            }
            Naziv = usluga.Naziv;
            Opis = usluga.Opis;
            Cijena = usluga.Cijena;
            try
            {
                var responseRecommendedUsluge = await service.GetRecommended<List<Usluga>>(usluga.Id, "RecommendedUsluge");



                foreach (var u in responseRecommendedUsluge)
                {
                    UslugeList.Add(u);
                }


            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Error code: " +ex.Message,"OK");
            }




        }



    }
}
