using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank {
	internal class Program {
		static void Main(string[] args) {
            // namespace e chamada de classe dentro de classe
            Console.WriteLine("Executando Projeto 5");
            Console.WriteLine();

            // chamando a nova classe
            Cliente gabriela =  new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
			Console.WriteLine(conta.titular.profissao);
			Console.WriteLine();

			// mudança de titular
			conta.titular.nome = "Paula";
			Console.WriteLine(gabriela.nome);
			Console.WriteLine(conta.titular.nome);
			Console.WriteLine(conta.titular.profissao);
            Console.WriteLine();


			// referencias nulas
			//ContaCorrente conta = new ContaCorrente();
			conta.titular = new Cliente(); // se não faz isso, nossa referencia não aponta pra nenhum lugar
            conta.titular.nome = "João Silva";
            conta.titular.cpf = "485.563.279-82";
            conta.titular.profissao = "Desenvolvedor Java";

            Console.WriteLine(conta.titular.nome);
			Console.WriteLine(conta.titular.cpf);
			Console.WriteLine(conta.titular.profissao);
			Console.WriteLine(conta.titular); // resultado nulo se não tivermos nossa referencia apontada pra algum lugar
			Console.WriteLine();


			// propriedade endereco iniciada dentro da propria classe
            // se tivesse sido iniciado aqui ficaria:
			Cliente cliente = new Cliente();
            //cliente.endereco = new Endereco(); // ficaria com essa linha
            cliente.endereco.numero = 153;
            Console.WriteLine(cliente.endereco.numero);

        }
	}
}
