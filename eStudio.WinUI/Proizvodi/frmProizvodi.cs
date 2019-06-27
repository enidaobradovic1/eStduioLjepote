using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService aPIServiceVrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService aPIServiceProizvodi = new APIService("Proizvodi");
        public frmProizvodi()
        {
            InitializeComponent();
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await vrsteProizvoda_Load();

        }
        private async Task vrsteProizvoda_Load()
        {
            var result= await aPIServiceVrsteProizvoda.Get<List<eStudioLjepote.Model.VrsteProizvoda>>(null);
            result.Insert(0, new eStudioLjepote.Model.VrsteProizvoda());
            comboBoxVrstaProizvoda.DisplayMember = "Naziv";
            comboBoxVrstaProizvoda.ValueMember = "Id";
            comboBoxVrstaProizvoda.DataSource = result;
        }

        private async void comboBoxVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboBoxVrstaProizvoda.SelectedValue;
            if(int.TryParse(idObj.ToString(),out int id))
            {
                await Proizvodi_Load(id);

            }
        }
        private async Task Proizvodi_Load(int VrstaProizvodaId)
        {
            var result = await aPIServiceProizvodi.Get<List<eStudioLjepote.Model.Proizvod>>(new ProizvodSearchRequest() {
                VrstaProizvodaId = VrstaProizvodaId
            });
            dgvProizvodi.AutoGenerateColumns = false;

            dgvProizvodi.DataSource = result;

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

            await aPIServiceProizvodi.Insert<eStudioLjepote.Model.Proizvod>(request);
            MessageBox.Show("Uspjesna operacija!");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInserPhoto_Click(object sender, EventArgs e)
        {
          var result=openFileDialog1.ShowDialog();
           if(result==DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;
             
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;            }
        }

        

        

        private void dgvProizvodi_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = dgvProizvodi.SelectedRows[0].Cells[0].Value;
            frmProizvodiDetalji frm = new frmProizvodiDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
    }