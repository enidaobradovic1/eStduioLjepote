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
   public  class UslugeViewModel
    {
        private readonly APIService service = new APIService("Usluge");
        public UslugeViewModel()
        {
            InitCommand = new Command(async ()  =>await Init());
        }
        public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await service.Get<List<Usluga>>(null);
            UslugeList.Clear();
            foreach(var usluga in list)
            {
                UslugeList.Add(usluga);
            }
        }
    }
}
