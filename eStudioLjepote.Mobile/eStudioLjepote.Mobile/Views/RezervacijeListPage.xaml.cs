using eStudioLjepote.Mobile.ViewModels;
using eStudioLjepote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudioLjepote.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RezervacijeListPage : ContentPage
	{
        private RezervaicijeListeViewModel model = null;
        public RezervacijeListPage ()
		{
			InitializeComponent ();
            BindingContext = model = new RezervaicijeListeViewModel();
		}
        protected override  async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
        private void ReservationsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new RezeracijeDetaljiPage((e.Item as Rezervacija).Id));
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RezervacijeAddPage());
        }
    }
}