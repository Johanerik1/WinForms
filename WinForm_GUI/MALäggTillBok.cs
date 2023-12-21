using BusinessEntities;
using ServiceLager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_GUI
{
    public partial class MALäggTillBok : Form
    {
        private LogicService logicService;
        public MALäggTillBok(LogicService logicService)
        {
            InitializeComponent();

            this.logicService = logicService;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSparaBok_Click(object sender, EventArgs e)
        {
            Bok nyBok = new Bok();

            nyBok.Titel = txtTitel.Text;
            nyBok.Författare = txtFörfattare.Text;
            nyBok.TillhörandeBokmaskin = txtTågstation.Text;
            nyBok.ÄrTillgänglig = chbTillgänglighet.Checked;

            logicService.LäggTillBok(nyBok);

            MessageBox.Show("Boken är Tillagd! Uppdatera vyn :)");

            this.Close();


        }

        private void MALäggTillBok_Load(object sender, EventArgs e)
        {

        }

        
    }
}
