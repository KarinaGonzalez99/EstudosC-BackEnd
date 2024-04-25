using _02_ByteBank.Funcionarios;
using _02_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	internal class Program {
		static void Main(string[] args) {
			/*CalcularBonificacao();*/ // ele reclama pois estamos chamando um método não estatico em um método estatico

			UsarSistema();

			//Program programa = new Program(); // não mto usado <<<<<
			//programa.CalcularBonificacao();
		}


		// CALCULA BONIFICAÇÃO
		public static void CalcularBonificacao() { // a solução é tornar esse método estatico ou criar uma nova instancia de program ^^^^^^
			GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

			//funcionario carlos = new funcionario("54878", 200); // percebe-se que á abstração do funcionario não deveria poder adicionar, pois cada funcionario tem sua particularidade com base no seu cargo, pra isso vamos impedir de poderem adcionar no funcionario diretamente
			//carlos.getbonificacao();

			Designer funcionario1 = new Designer("833.546.257-99");
			funcionario1.Nome = "Pedro";

			Diretor funcionario2 = new Diretor("123.456.789-10");
			funcionario2.Nome = "Roberta";

			Auxiliar funcionario3 = new Auxiliar("789.456.123-78");
			funcionario3.Nome = "Igor";

			GerenteDeConta funcionario4 = new GerenteDeConta("456.123.789-23");
			funcionario4.Nome = "Camila";

			Desenvolvedor funcionario5 = new Desenvolvedor("159.263.487-63");
			funcionario4.Nome = "Guilherme";

			gerenciadorBonificacao.Registrar(funcionario1);
			gerenciadorBonificacao.Registrar(funcionario2);
			gerenciadorBonificacao.Registrar(funcionario3);
			gerenciadorBonificacao.Registrar(funcionario4);
			gerenciadorBonificacao.Registrar(funcionario5);

			Console.WriteLine($"Total de bonificações do mês {gerenciadorBonificacao.GetTotalBonificacao()}");

		}

		public static void UsarSistema() {
			SistemaInterno sistemaInterno = new SistemaInterno();

			// para apenas os dois poderem usar eles foram declarados não mais como herança do funcionarios e sim do autenticavel
			Diretor funcionario2 = new Diretor("123.456.789-10");
			funcionario2.Nome = "Roberta";
			funcionario2.Senha = "1234";

			GerenteDeConta funcionario4 = new GerenteDeConta("456.123.789-23");
			funcionario4.Nome = "Camila";
			funcionario4.Senha = "abc";

			//Designer funcionario1 = new Designer("833.546.257-99"); // apenas o diretor e o gerente tem esse acesso, então vamos limitar apenas aos dois
			//funcionario1.Nome = "Pedro";
			//funcionario2.Senha = "123";

			ParceiroComercial parceiro = new ParceiroComercial();
			parceiro.Senha = "123456";


			sistemaInterno.Logar(funcionario2, "1234");
			sistemaInterno.Logar(funcionario2, "ABC");
			sistemaInterno.Logar(funcionario4, "abc");
			sistemaInterno.Logar(funcionario2, "123");
			sistemaInterno.Logar(parceiro, "123456");
			sistemaInterno.Logar(parceiro, "abc");
			//sistemaInterno.Logar(funcionario1, "123");
			//sistemaInterno.Logar(funcionario1, "ABC");
		}
	}
}
