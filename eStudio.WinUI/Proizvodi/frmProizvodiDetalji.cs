using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;

namespace eStudio.WinUI.Proizvodi
{
    public partial class frmProizvodiDetalji : Form
    {
        private readonly APIService aPIServiceVrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService aPIServiceProizvodi = new APIService("Proizvodi");
        private int? _proizvodId;
        SqlConnection sqlConnection = new SqlConnection("Server =.; Database=150023;Trusted_Connection=True;ConnectRetryCount=0");
        SqlCommand SqlCommand;
        SqlDataAdapter adapter; 
        public frmProizvodiDetalji(int? proizvodId=null)
        {
            InitializeComponent();
            _proizvodId = proizvodId;
        }

        private async void frmProizvodiDetalji_Load(object sender, EventArgs e)
        {
            await vrsteProizvoda_Load();
            if (_proizvodId.HasValue)
            {
                var proizvod = await aPIServiceProizvodi.GetById<Proizvod>(_proizvodId);
                var vrstaProizvoda = await aPIServiceVrsteProizvoda.GetById<VrsteProizvoda>(proizvod.VrstaProizvodaId);

                txtSifra.Text = proizvod.Sifra;
                txtNazivProizvoda.Text = proizvod.Naziv;
                txtCijena.Text = proizvod.Cijena.ToString();
                txtSkladiste.Text = proizvod.KolicinaUskladiste.ToString();
                MemoryStream memoryStream = new MemoryStream(proizvod.Slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
                comboBoxVrstaProizvoda.Text = vrstaProizvoda.Naziv;
                request.Slika = proizvod.Slika;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private async Task vrsteProizvoda_Load()
        {
            var result = await aPIServiceVrsteProizvoda.Get<List<eStudioLjepote.Model.VrsteProizvoda>>(null);
            result.Insert(0, new eStudioLjepote.Model.VrsteProizvoda());
            comboBoxVrstaProizvoda.DisplayMember = "Naziv";
            comboBoxVrstaProizvoda.ValueMember = "Id";
            comboBoxVrstaProizvoda.DataSource = result;
        }
        ProizvodUpsertRequest request = new ProizvodUpsertRequest();
        private async void btnSacuvajProizvod_Click(object sender, EventArgs e)
        {

            var idObj = comboBoxVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaProizvodaId = vrstaId;
            }



            request.Naziv = txtNazivProizvoda.Text;
            request.Sifra = txtSifra.Text;
            request.Cijena = decimal.Parse(txtCijena.Text);
            request.KolicinaUskladiste = int.Parse(txtSkladiste.Text);
            request.DatumKupovine = DateTime.Parse(dateTimePickerDatumKupovine.Text);
           

            await aPIServiceProizvodi.Update<eStudioLjepote.Model.Proizvod>(_proizvodId,request);
            MessageBox.Show("Uspjesna operacija!");
        }

        private void btnInserPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void btnInserPhoto_Click_1(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }
    }
}
