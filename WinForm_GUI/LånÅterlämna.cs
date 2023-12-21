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
    public partial class LånÅterlämna : Form
    {
        private LogicService logicService;
        private Bokmaskin? valdBokmaskin;
        private LånÅterlämna lån;
        

        public LånÅterlämna(LogicService logicService)
        {
            InitializeComponent();
            this.logicService = logicService;
            
        }

        private void dgvBokmaskiner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBokmaskin = dgvBokmaskiner.SelectedRows[0].DataBoundItem as Bokmaskin;
        }

        private void UppdateraVy()
        {
            dgvBokmaskiner.DataSource = new BindingList<Bokmaskin>(logicService.HämtaBokmaskin());

        }

        private void LånÅterlämna_Load(object sender, EventArgs e)
        {
            UppdateraVy();
        }

        private void btnVäljStation_Click(object sender, EventArgs e)
        {
            Väljbok väljbok = new Väljbok(logicService);
            väljbok.Show();
        
        }

       



    }
}



