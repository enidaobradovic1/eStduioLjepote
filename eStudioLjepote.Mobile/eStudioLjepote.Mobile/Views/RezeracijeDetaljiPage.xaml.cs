using eStudioLjepote.Mobile.ViewModels;
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
	public partial class RezeracijeDetaljiPage : ContentPage
	{
        private RezervacijaDetaljiViewModel model;

        public RezeracijeDetaljiPage (int id)
		{
			InitializeComponent ();
            BindingContext = model = new RezervacijaDetaljiViewModel()
            {
                RezervacijaID = id
            };
        }
        protected override  async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}