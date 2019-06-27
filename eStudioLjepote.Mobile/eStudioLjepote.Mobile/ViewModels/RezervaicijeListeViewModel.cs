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
   public  class RezervaicijeListeViewModel
    {
        private readonly APIService RezervacijaService = new APIService("Rezervacija");
        
        public RezervaicijeListeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ICommand InitCommand { get; set; }
       
  

        public async Task Init()
        {
            var list = await RezervacijaService.Get<List<Rezervacija>>(null);

            RezervacijeList.Clear();
          
            foreach (var rezervacija in list)
            {
                if (rezervacija.KlijentId == 1)
                {
                 
                    RezervacijeList.Add(rezervacija);
                   
                }
                    
            }
        }
    }

}
