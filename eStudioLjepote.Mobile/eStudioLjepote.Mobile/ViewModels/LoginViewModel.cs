using eStudioLjepote.Mobile.Views;
using eStudioLjepote.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eStudioLjepote.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService service = new APIService("Klijenti");
       
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

       

        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        string password = string.Empty;

       

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {

                await service.Get<dynamic>(null);
              
                Application.Current.MainPage = new MainPage();
                      
       

               
            }
            catch (Exception ex)
            {
               await Application.Current.MainPage.DisplayAlert("Greška",ex.Message, "OK");
            }
        }

    }
}
