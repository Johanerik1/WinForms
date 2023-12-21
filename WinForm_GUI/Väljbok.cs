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
    public partial class Väljbok : Form
    {
        private LogicService logicService;
        private Bok valdBok;

        public Väljbok(LogicService logicService)
        {
            InitializeComponent();
            this.logicService = logicService;
        }

        private void dataGridViewBöckerAttLåna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBok = dataGridViewBöckerAttLåna.SelectedRows[0].DataBoundItem as Bok;
        }

        private void Väljbok_Load(object sender, EventArgs e)
        {
           dataGridViewBöckerAttLåna.DataSource = new BindingList<Bok>(logicService.HämtaBöcker());
        }

        


    }
}
