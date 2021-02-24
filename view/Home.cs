using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleRevendaWF.view
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void OpenRevendedoras(object sender, EventArgs e)
        {
            new RevendedorasVisualizar().Show();

        }
    }
}
