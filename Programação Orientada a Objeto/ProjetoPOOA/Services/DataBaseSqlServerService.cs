// Importar biblioteca de banco
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPOOA.Services
{
    public class DataBaseSqlServerService
    {
        // Metodo para conectar com o banco de dados
        private SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection();

            // Os dados para conectar ao Banco
            conexao.ConnectionString =
                "Data Source=VICTOR\\SQLEXPRESS;" + // Servidor
                "Initial Catalog=ProjetoPOOA;" + // Nome do Banco
                "Integrated Security=SSPI;" + // Autenticação do Windows
                "User Instance=false;"; // Usar o usuario da maquina

            conexao.Open(); // Abrir a conexão com o banco
            return conexao;
        }
    }
}
