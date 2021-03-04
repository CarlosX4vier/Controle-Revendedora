using ControleRevendaWF.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ControleRevendaWF.DAO
{
    public class RevendedorasDAO
    {
        public List<Revendedora> revendedoras = new List<Revendedora>();

        public List<Revendedora> GetAll()
        {
            Conexao conexao = new Conexao();
            List<Revendedora> revendedorasResult = new List<Revendedora>();
            string sql = "SELECT * FROM revendedoras ";

            using (MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Revendedora revendedora = new Revendedora();
                        revendedora.Id = reader.GetInt64(reader.GetOrdinal("rev_id"));
                        revendedora.Nome = reader.GetString(reader.GetOrdinal("rev_nome"));
                        revendedora.Sobrenome = reader.GetString(reader.GetOrdinal("rev_sobrenome"));
                        revendedorasResult.Add(revendedora);
                    }
                }
            }
            return revendedorasResult;
        }

        public Revendedora Get(long id)
        {
            Conexao conexao = new Conexao();
            string sql = "SELECT * FROM revendedoras WHERE rev_id = @id ";

            using (MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Revendedora revendedora = new Revendedora();
                        revendedora.Id = reader.GetInt64(reader.GetOrdinal("rev_id"));
                        revendedora.Nome = reader.GetString(reader.GetOrdinal("rev_nome"));
                        revendedora.Sobrenome = reader.GetString(reader.GetOrdinal("rev_sobrenome"));
                        return revendedora;
                    }
                }
            }
            return new Revendedora();
        }

        public long Insert(Revendedora revendedora)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "INSERT INTO revendedoras (rev_nome, rev_sobrenome) " +
                    "VALUES (@nome, @sobrenome); SELECT LAST_INSERT_ID ()";
                using (MySqlCommand command = conexao.GetConexao().CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@nome", revendedora.Nome);
                    command.Parameters.AddWithValue("@sobrenome", revendedora.Sobrenome);

                    return (long)command.ExecuteScalar();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool Update(Revendedora revendedora)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "UPDATE revendedora " +
                    "SET rev_nome = @nome, " +
                    "rev_sobrneome = @sobrenome" +
                    "WHERE rev_id = @id ";
                using (MySqlCommand command = conexao.GetConexao().CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@nome", revendedora.Nome);
                    command.Parameters.AddWithValue("@sobrenome", revendedora.Sobrenome);
                    command.Parameters.AddWithValue("@id", revendedora.Id);

                    return command.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateCatalogos(Revendedora revendedora, Catalogo catalogo)
        {
            try
            {
                string sql = "UPDATE catalogos_revendedoras " +
                                "SET cr_porcentagem = @porcentagem " +
                                "WHERE cr_catalogo = @catalogo AND " +
                                "cr_revendedora = @revendedora";

                Conexao conexao = new Conexao();

                using (MySqlCommand command = conexao.GetConexao().CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@catalogo", catalogo.Id);
                    command.Parameters.AddWithValue("@porcentagem", catalogo.Porcentagem);
                    command.Parameters.AddWithValue("@revendedora", revendedora.Id);

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public long InsertCatalogos(Revendedora revendedora, Catalogo catalogo)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "INSERT INTO catalogos_revendedoras (cr_revendedora, cr_porcentagem, cr_catalogo) " +
                    "VALUES (@revendedora,@porcentagem,@catalogo); SELECT LAST_INSERT_ID ()";

                using (MySqlCommand command = conexao.GetConexao().CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@revendedora", revendedora.Id);
                    command.Parameters.AddWithValue("@porcentagem", catalogo.Porcentagem);
                    command.Parameters.AddWithValue("@catalogo", catalogo.Id);

                    return long.Parse(command.ExecuteScalar().ToString());
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
