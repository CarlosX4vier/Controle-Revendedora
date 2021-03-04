using ControleRevendaWF.Controllers;
using ControleRevendaWF.DAO;
using ControleRevendaWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleRevendaWF.view
{
    public partial class RevendedorasCadastrar : Form
    {
        public long IdUser;
        private RevendedorasController controller = new RevendedorasController();
        public RevendedorasCadastrar()
        {
            InitializeComponent();

            List<Catalogo> catalogos = new CatalogosDAO().GetCatalogos();

            foreach (var item in catalogos)
            {
                gridCatalogos.Rows.Add(new object[] { item.Id, item.Nome, item.Porcentagem });
            }


        }



        public RevendedorasCadastrar(long id)
        {
            InitializeComponent();
            IdUser = id;
            Revendedora rev = controller.Get(id);

            txtNome.Text = rev.Nome;
            txtSobrenome.Text = rev.Sobrenome;

            List<Catalogo> catalogos = new CatalogosDAO().GetCatalogos();

            foreach (var item in catalogos)
            {
                int valor = 0;
                int indexCatalogo = rev.Catalogos.FindIndex(x => x.Id == item.Id);
                if (indexCatalogo > -1)
                {
                    valor = rev.Catalogos[indexCatalogo].Porcentagem;
                }

                gridCatalogos.Rows.Add(new object[] { item.Id, item.Nome, valor });

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Revendedora revendedora = new Revendedora() {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text
            };

            foreach (DataGridViewRow item in gridCatalogos.Rows)
            {
                Catalogo catalogo = new Catalogo()
                {
                    Id = (long)item.Cells[0].Value,
                    Nome = (string)item.Cells[1].Value,
                    Porcentagem = int.Parse(item.Cells[2].Value.ToString())
                };

                revendedora.Catalogos.Add(catalogo);
            }
            if (IdUser != 0)
            {
                revendedora.Id = IdUser;
                new RevendedorasController().Update(revendedora);
               
            }
            else
            {
                new RevendedorasController().Insert(revendedora);
            }
        }
    }
}
