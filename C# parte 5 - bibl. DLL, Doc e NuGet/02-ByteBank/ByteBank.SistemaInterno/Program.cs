using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// a ideia desse projeto 2 é poder utilizar uma biblitoteca que está em outro local, além de outras funcionalidades
// a biblitoteca gera um dll, e é ele que iremos referenciar, não podemos referenciar direto do bin e debug pois lá é uma versão instavel
// pra isso copiamos a dll e colamos em um arquivo de biblioteca, onde ele terá uma versão estavel
// vá agora em referencia, clicar em adicionar referencia e procurar onde vc colou

namespace ByteBank.SistemaInterno {
	internal class Program {
		static void Main(string[] args) {
			ContaCorrente conta = new ContaCorrente(574, 87867);
            Console.WriteLine(conta.Saldo);
			conta.Sacar(-10);
			// se vc clica pra ver a string, vc só ve os dados, vc não ve o codigo fonte da string, o mesmo acontece com a nossa biblioteca
			// vc não ve o codigo fonte dessa dll, vc vê os dados
			string nome = "Sunna";
			Console.WriteLine(nome);

            Console.ReadLine();
		}
	}
}
