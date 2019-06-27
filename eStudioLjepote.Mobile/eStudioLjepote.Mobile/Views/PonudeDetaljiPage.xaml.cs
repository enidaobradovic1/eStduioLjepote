using eStudioLjepote.Mobile.ViewModels;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudioLjepote.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PonudeDetaljiPage : ContentPage
	{
        private readonly APIService Ocjeneservice = new APIService("Ocjene");
        private UslugeDeljatiViewModel model = null;
        private readonly APIService service = new APIService("Usluge");
        public PonudeDetaljiPage (int id)
		{
			InitializeComponent ();
            BindingContext = model = new UslugeDeljatiViewModel()
            {
                UslugaID = id
            };

           
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
         

        }

        

        private async void RateButton_Clicked(object sender, EventArgs e)
        {
            OcjeneUpsertRequest request = new OcjeneUpsertRequest();
            request.KlijentId = 1;
            request.UslugeId = model.UslugaID;
            request.Rating1 = model.Ocjena;

            await Ocjeneservice.Insert<Ocjene>(request);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           
                if (e.Item != null)
                {
                    this.Navigation.PushAsync(new PonudeDetaljiPage((e.Item as Usluga).Id));
                }
            
        }
    }
}