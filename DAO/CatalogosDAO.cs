using ControleRevendaWF.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ControleRevendaWF.DAO
{
    public class CatalogosDAO
    {

        public bool UpdateCatalogosFromRevendedora(Catalogo catalogo, long idRevendedora)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "UPDATE catalogos_revendedoras " +
                    "SET cr_porcentagem = @porcentagem" +
                    "WHERE cr_catalogo = @catalogo AND cr_revendedora = @revendedora ";
                using (MySqlCommand command = conexao.GetConexao().CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@porcentagem", catalogo.Porcentagem);
                    command.Parameters.AddWithValue("@catalogo", catalogo.Id);
                    command.Parameters.AddWithValue("@revendedora", idRevendedora);

                    return command.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Catalogo> GetCatalogosByRevendedora(long revendedora)
        {
            List<Catalogo> catalogos = new List<Catalogo>();

            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM catalogos_revendedoras " +
            "LEFT JOIN catalogos ON cr_catalogo = cat_id " +
            "WHERE cr_revendedora = @id ";

            using (MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;
                command.Parameters.AddWithValue("@id", revendedora);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Catalogo catalogo = new Catalogo();
                        catalogo.Id = reader.GetInt64(reader.GetOrdinal("cr_catalogo"));
                        catalogo.Nome = reader.GetString(reader.GetOrdinal("cat_nome"));
                        catalogo.Porcentagem = reader.GetInt32(reader.GetOrdinal("cr_porcentagem"));

                        catalogos.Add(catalogo);
                    }
                }
            }
            return catalogos;
        }

        public List<Catalogo> GetCatalogos()
        {
            List<Catalogo> catalogos = new List<Catalogo>();

            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM catalogos";

            using (MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Catalogo catalogo = new Catalogo();
                        catalogo.Id = reader.GetInt64(reader.GetOrdinal("cat_id"));
                        catalogo.Nome = reader.GetString(reader.GetOrdinal("cat_nome"));

                        catalogos.Add(catalogo);
                    }
                }
            }
            return catalogos;
        }
    }
}
