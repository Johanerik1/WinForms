using BusinessEntities;
using ServiceLager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_GUI
{
    public partial class LoggaIn : Form
    {
        private LogicService logicService;
        
        public LoggaIn(LogicService logicService)
        {
            InitializeComponent();
            this.logicService = logicService;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string användarnamn = txtAnvändarnamn.Text;
            string lösenord = txtLösenord.Text;

            bool inloggningLyckad = logicService.VerifieraInloggning(användarnamn, lösenord, out bool ärMaskínansvarig);

            if (inloggningLyckad) 
            {
                if (ärMaskínansvarig)
                {
                    MAHanteraBok mAHanteraBok = new MAHanteraBok(logicService);
                    mAHanteraBok.Show();
                }
                else 
                { 
                    LånÅterlämna lånÅterlämna = new LånÅterlämna(logicService); 
                    lånÅterlämna.Show();
                }
                MessageBox.Show("Inloggningen Lyckades!");

            }
            else 
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord...");
            }

        }

        


        
    
    }
}
