using ControleRevendaWF.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleRevendaWF.view
{
    public partial class LoadingScreen : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public bool isOpen = false;
        public LoadingScreen()
        {
            InitializeComponent();

            progressBar1.Value = 0;

            try
            {
                bool con = new Conexao().GetConexao() != null;
                progressBar1.Value = 15;
                timer.Interval = 4000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar no banco");
                Application.Exit();
            }
    
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100;

            isOpen = true;
            this.Close();
            timer.Stop();
        }
    }
}
