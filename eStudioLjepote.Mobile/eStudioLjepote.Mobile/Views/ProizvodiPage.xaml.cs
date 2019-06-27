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
	public partial class ProizvodiPage : ContentPage
	{
        private ProizvodiViewModel model = null;
		public ProizvodiPage ()
		{
			InitializeComponent ();
            BindingContext = model = new ProizvodiViewModel();
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}