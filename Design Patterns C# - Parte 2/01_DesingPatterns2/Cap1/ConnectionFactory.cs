using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap1
{
	class ConnectionFactory
	{
		public IDbConnection GetConnection()
			// isolamos nesse codigo
		{
			// conectarmos no banco de dados
			IDbConnection conexao = new SqlConnection();
			conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
			conexao.Open();
			return conexao;
		}
	}
}
