using eStudioLjepote.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.Model;

namespace eStudioLjepote.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RezervacijeAddPage : ContentPage
	{
        private readonly APIService RezervacijaService = new APIService("Rezervacija");
        private RezervacijaAddViewModel model = null;
        public RezervacijeAddPage ()
		{
			InitializeComponent ();
            BindingContext = model = new RezervacijaAddViewModel();
		}

        protected override async  void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void AddReservaction_Clicked(object sender, EventArgs e)
        {
            RezervacijaInsertRequest request = new RezervacijaInsertRequest()
            {
                DatumRezervacije = ResrvationDatePicker.Date,
                Vrijeme = TimePickerReservation.Time.ToString(),
                KlijentId = 1,
                Otkazano = false,
                Prihvaceno = false,
                UslugeId = model.SelectedUsluga.Id,
                BrojOsoba = Convert.ToInt32(BrojGostiju.Text)


            };
            await RezervacijaService.Insert<Rezervacija>(request);
            await Application.Current.MainPage.DisplayAlert("Rezervacija", "Uspjesna operacija!", "OK");
        }

        
    }
}