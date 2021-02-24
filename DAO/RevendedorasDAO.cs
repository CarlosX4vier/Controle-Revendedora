using ControleRevendaWF.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            using(MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;
                using(MySqlDataReader reader = command.ExecuteReader())
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

        public List<Revendedora> Get(long id)
        {
            Conexao conexao = new Conexao();
            List<Revendedora> revendedorasResult = new List<Revendedora>();
            string sql = "SELECT * FROM revendedoras WHERE rev_id = @id ";

            using (MySqlCommand command = conexao.GetConexao().CreateCommand())
            {
                command.CommandText = sql;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    command.Parameters.AddWithValue("@id", id);
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
    }
}
