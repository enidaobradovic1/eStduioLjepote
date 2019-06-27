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
	public partial class PonudePage : ContentPage
	{
        private UslugeViewModel model = null;
		public PonudePage ()
		{
			InitializeComponent ();
            BindingContext = model = new UslugeViewModel();
            
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        public void UslugeList_Tapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new PonudeDetaljiPage((e.Item as Usluga).Id));
            }
        }
       
    }
    }