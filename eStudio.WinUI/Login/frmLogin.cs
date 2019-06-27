using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eStudio.WinUI.Main;
using eStudioLjepote.Model;

namespace eStudio.WinUI.Login
{
    public partial class frmLogin : Form
    {
        APIService aPIService = new APIService("Zaposlenici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorisnickoIme.Text;
            APIService.Password = txtLozinka.Text;
            try
            {
               await aPIService.Get<dynamic>(null);
                var list = await aPIService.Get<List<Zaposlenik>>(null);
                foreach (var z in list)
                {
                    if(APIService.Username==z.Username)
                    {
                        Global.LoggedUser = z;
                    }
                }
                frmMain frm = new frmMain();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }
    }
}
