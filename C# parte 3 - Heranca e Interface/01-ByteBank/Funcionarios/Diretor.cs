using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios {
	public class Diretor : Funcionario { // se a cada classe criada tivessemos que criar igual, podemos usar a herança e pra isso usamos o ":"

		// metodo pra obrigatoriedade do cpf registrado, além do que a base faz
		public Diretor(string cpf, double salario) : base(cpf, salario) { // por termos colocado que o cpf era obrigatorio, temos que usar o método pra podermos usar da base os dados e passar a obriagtoriedade do cpf(no caso)
			Console.WriteLine("CRIANDO DIRETOR"); // PRIMEIRO é chamado o CRIANDO FUNCIONARIO e depois logo em seguida o CRIANDO DIRETOR
		}


		// por ter herança ele não precisa mais repetir
		//public string Nome { get; set; }
		//public string CPF { get; set; }
		//public double Salario { get; set; }

		// metodo aumentar salario DIRETOR
		public override void AumentarSalario() { // por eu ter feito o set ser private, ele não consegue alterar aqui pra isso eu transformo ele em protected não privado
			Salario *= 1.15;
		}

		// metodo de bonificar versão diretor que usa a base + bonificação propria sobreescrevendo a do funcionario
		public override double GetBonificacao() { // reclamando por ter o mesmo nome, pra isso em funcionarios vamos habilitar sobreescrever (virtual) e usar o override aqui
			/*return Salario;*/ // a bonificacao do diretor vai ser agora salario + (salario * 0.10), ou seja, é o salario + a bonificação do funcionario
								//return Salario + (Salario * 0.10); // como é o salario mais a bonificação padrão do funcionario, se alterasse o padrão vc teria que mudar tudo manualmente, pra isso vc chama o método:
			/*return Salario + GetBonificacao();*/ // o problema é que cria um StackOverflowException, ou seja looping e quebra, pois ele entende que o que a gnt sobreescreveu, pra isso usamos base
			return Salario + base.GetBonificacao(); // ou seja, chama os membros da classe base
		}

	}
}
