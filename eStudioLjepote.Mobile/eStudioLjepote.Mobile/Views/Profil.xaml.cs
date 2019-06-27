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
	public partial class Profil : ContentPage
	{
        private KlijentProfilViewModel model = null;
        public Profil ()
		{
			InitializeComponent ();
            BindingContext = model = new KlijentProfilViewModel();
            
        }
        protected override async void OnAppearing()
        {
            await model.Init();
            base.OnAppearing();

        }


    }
}