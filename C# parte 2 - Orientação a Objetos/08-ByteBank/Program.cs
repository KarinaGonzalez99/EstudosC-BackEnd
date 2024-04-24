using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			// construtores
			Console.WriteLine("Executando Projeto 8");
			Console.WriteLine(ContaCorrente.TotalDeContasCriadas); // so consigo ver pq é publico

			ContaCorrente conta = new ContaCorrente(876, 86712540); // agora como foi forçado vc passa os parametros por aqui

			//conta.Numero = 86712540;
			//conta.Agencia = 876; // se simularmos que esquemos a agencia, ele simplesmente responde como 0, por isso temos que obrigar para não passar esse erro

			conta.Agencia = -10; // ele simplesmente ignorou, nem executa
			Console.WriteLine(conta.Agencia);
			Console.WriteLine(conta.Numero);
			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


			/*conta.TotalDeContasCriadas++; */// por ser caracteristica da classe, é inviavel vc manter toda vez que adicionar
											  //ContaCorrente.TotalDeContasCriadas++; // ainda inviavel fazer na mao um a um

			ContaCorrente contaDaGabi = new ContaCorrente(562, 1886259390);
			//contaDaGabi.TotalDeContasCriadas = 2; // inviavel... não é uma caracteristica da conta da Gabi e sim da classe
			//ContaCorrente.TotalDeContasCriadas++; // ainda inviavel fazer na mao um a um

			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


		}
	}
}
