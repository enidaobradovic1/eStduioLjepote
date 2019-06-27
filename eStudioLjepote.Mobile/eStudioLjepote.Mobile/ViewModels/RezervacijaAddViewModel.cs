using eStudioLjepote.Mobile.ViewModels;
using eStudioLjepote.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using eStudioLjepote.Model.Requests;
namespace eStudioLjepote.Mobile.Views
{
    public class RezervacijaAddViewModel:BaseViewModel
    {
        private readonly APIService service = new APIService("Usluge");
        private readonly APIService RezervacijaService = new APIService("Rezervacija");
        public RezervacijaAddViewModel()
        {
            InitCommand = new Command(async () => await Init());
            
        }
     
       

        Usluga _SelectedUsluga = null;
        public Usluga SelectedUsluga
        {
            get { return _SelectedUsluga; }
            set
            {
                SetProperty(ref _SelectedUsluga, value);
              
            }
        }
     

        public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();
        public ICommand InitCommand { get; set; }
        //public ICommand AddCommand { get; set; }
        public async Task Init()
        {
            var list = await service.Get<List<Usluga>>(null);
            UslugeList.Clear();
            foreach (var usluga in list)
            {
                UslugeList.Add(usluga);
            }
        }
       
        


    }
}
