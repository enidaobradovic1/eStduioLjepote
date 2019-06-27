using eStudio.WinUI.Klijenti;
using eStudio.WinUI.Plate;
using eStudio.WinUI.Proizvodi;
using eStudio.WinUI.Rezervacije;
using eStudio.WinUI.Uplate;
using eStudio.WinUI.Usluge;
using eStudio.WinUI.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnZaposleniciHome_Click(object sender, EventArgs e)
        {
            frmZaposlenici frm = new frmZaposlenici();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        
        private void btnProizvodiHome_Click(object sender, EventArgs e)
        {
            frmProizvodi frm = new frmProizvodi();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUsluge frm = new frmUsluge();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnKlijentiHome_Click(object sender, EventArgs e)
        {
            frmKlijenti frm = new frmKlijenti();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmRezervacije frm = new frmRezervacije();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnUplate_Click(object sender, EventArgs e)
        {
            frmUplate frm = new frmUplate();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnPlate_Click(object sender, EventArgs e)
        {
            frmPlate frm = new frmPlate();
            frm.MdiParent = frmHome.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
