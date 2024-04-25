using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	public abstract class Funcionario { // aqui falamos que é abstrato pra pode impedir essas modificações diretas porque não faz muito sentido
		public static int TotalDeFuncionarios { get; private set; }
		public string Nome { get; set; }
		public string CPF { get; private set; }
		public double Salario { get; protected set; }

		// metodo de quantificação de funcionarios
		public Funcionario(string cpf, double salario) {
			Console.WriteLine("CRIANDO FUNCIONARIO");
			CPF = cpf;
			Salario = salario;
			TotalDeFuncionarios++;
		}

		// METODOS ABSTRATOS APENAS EM CLASSES ABSTRATAS
		// requisito do cliente - aumentar salario com base em % em cima do salario
		public abstract void AumentarSalario(); // { // obrigando as classes filhas a não esquecerem de adicionar
		/*Console.WriteLine("Atenção faltou método aumentar salario");*/ // ou criamos esse cw ou usamos abstract (esse é gambiarra)
		// }

		// metodo de retorno do processo de bonificação do funcionario de maneira virtual (podendo ser sobreescrito)
		public abstract double GetBonificacao(); // { // obrigando as classes filhas a não esquecerem de adicionar, substitui virtual como abstract, e com isso tiramos o {}
			//Console.WriteLine("Atenção faltou método get bonificação"); // ou criamos esse cw ou usamos abstract (esse é gambiarra)
			//return 0; // porque é double precisa
		// }
	}
}
