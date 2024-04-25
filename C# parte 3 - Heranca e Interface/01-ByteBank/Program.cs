using _01_ByteBank.Funcionarios; //ctrl . enter mais dinamismo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			//dados Funcionario
			Funcionario carlos = new Funcionario("456.045.486-63", 2000);
			carlos.Nome = "Carlos";
			//carlos.CPF = "456.045.486-63"; // coloquei como argumento, e é privado
			/*carlos.Salario = 2000;*/ // defini no método que salario é obrigatorio

			// teste total funcionarios
			Console.WriteLine(Funcionario.TotalDeFuncionarios);

			// testar bonificação
			gerenciador.Registrar(carlos);
			Console.WriteLine(carlos.Nome);
			Console.WriteLine(carlos.GetBonificacao());

			// testar aumentar salario
			Console.WriteLine($"Antigo salario do Carlos:{carlos.Salario}");
			carlos.AumentarSalario();
            Console.WriteLine($"Novo salario do Carlos:{carlos.Salario}");

			//dados Diretor
			Diretor roberta = new Diretor("635.987.254-65", 5000);
			roberta.Nome = "Roberta";
			//roberta.CPF = "635.987.254-65"; // privado
			//roberta.Salario = 5000; // defini no método que salario é obrigatorio

			// teste total funcionarios
			Console.WriteLine(Funcionario.TotalDeFuncionarios);

			// testar bonificação
			gerenciador.Registrar(roberta); // pela roberta ser diretora temos que criar um método pra diretor
			Console.WriteLine(roberta.Nome);
			Console.WriteLine(roberta.GetBonificacao());

			// testar aumentar salario
			Console.WriteLine($"Antigo salario do Roberta:{roberta.Salario}");
			roberta.AumentarSalario();
			Console.WriteLine($"Novo salario do Roberta:{roberta.Salario}");

			// testar total de bonificação
			Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

		}
	}
}
