using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis {
	internal class Program {
		static void Main(string[] args) {
            // atribuições de variaveis
            Console.WriteLine("Executando Projeto 6 - Abtribuições de variáveis");
            Console.WriteLine();

            // verifica o valor que a primeira armazena e copia esse valor pra segunda
            int idade = 32;
            int idadeGustavo = idade;
            idade = 20;
			Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

			Console.ReadLine();
        }
	}
}
