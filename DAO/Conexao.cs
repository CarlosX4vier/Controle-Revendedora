using MySql.Data.MySqlClient;

namespace ControleRevendaWF.DAO
{
    public class Conexao
    {
        private MySqlConnection conexao = new MySqlConnection("server=localhost;user=root;password=;Database=revendedora");
        public MySqlConnection GetConexao()
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            return conexao;
        }
    }


}
