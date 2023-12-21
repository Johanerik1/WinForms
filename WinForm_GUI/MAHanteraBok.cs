using BusinessEntities;
using ServiceLager;
using System.ComponentModel;
namespace WinForm_GUI
{
    public partial class MAHanteraBok : Form
    {
        
        private LogicService logicService;
        private Bok? valdBok;
        //private Bokmaskin? valdbokmaskin;
        public MAHanteraBok(LogicService logicService)
        {
            InitializeComponent();
            this.logicService = logicService;

        }

        private void RefresDataGridView()
        {
            dataGridView1.DataSource = new BindingList<Bok>(logicService.H�mtaB�cker());
        }

        private void btnRefreshDataGridView_Click(object sender, EventArgs e)
        {
            RefresDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBok = dataGridView1.SelectedRows[0].DataBoundItem as Bok;
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            RefresDataGridView();
        }

        private void btnTaBortBok_Click(object sender, EventArgs e)
        {
            if (valdBok != null) logicService.TaBortBok(valdBok);
            RefresDataGridView();
        }

        private void btnL�ggTillBok_Click(object sender, EventArgs e)
        {
            MAL�ggTillBok mAL�ggTillBok = new MAL�ggTillBok(logicService);
            mAL�ggTillBok.Show();
        }
    }
}
