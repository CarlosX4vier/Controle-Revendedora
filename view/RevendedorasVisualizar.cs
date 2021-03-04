using ControleRevendaWF.DAO;
using ControleRevendaWF.Models;
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
    public partial class RevendedorasVisualizar : Form
    {
        public RevendedorasVisualizar()
        {
            InitializeComponent();
            RevendedorasDAO revendedorasDAO = new RevendedorasDAO();
            List<Revendedora> r =revendedorasDAO.GetAll();
           foreach(Revendedora rev in r)
            {

                ListViewItem it = new ListViewItem(rev.Id.ToString());
                it.SubItems.Add(rev.Nome);
                it.SubItems.Add(rev.Sobrenome);
                listView1.Items.Add(it);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)  
            {
                MessageBox.Show("Selecione a revendedora antes de editar", "Atenção!");
            }
            else
            {
                long id = long.Parse(listView1.SelectedItems[0].Text);
                new RevendedorasCadastrar(id).Show();
            }
        }
    }
}
