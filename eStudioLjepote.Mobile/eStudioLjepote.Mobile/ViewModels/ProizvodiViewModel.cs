using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
   public  class ProizvodiViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Proizvodi");
        private readonly APIService _VrsteProizvodaService = new APIService("VrsteProizvoda");
        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();
        VrsteProizvoda _SelectedVrstaProizvoda = null;
        public VrsteProizvoda SelectedVrstaProizvoda
        {
            get { return _SelectedVrstaProizvoda; }
            set {
                SetProperty(ref _SelectedVrstaProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
       
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (VrsteProizvodaList.Count == 0)
            {
                var VrsteProizvodalist = await _VrsteProizvodaService.Get<List<VrsteProizvoda>>(null);
                foreach (var vrstaProizvoda in VrsteProizvodalist)
                {
                    VrsteProizvodaList.Add(vrstaProizvoda);
                }
            }
            if(SelectedVrstaProizvoda!=null)
            {
                ProizvodSearchRequest search = new ProizvodSearchRequest();
                search.VrstaProizvodaId = SelectedVrstaProizvoda.Id;

                var list = await _service.Get<List<Proizvod>>(search);

                ProizvodiList.Clear();
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
                }

            }
         
        }
    }
}
