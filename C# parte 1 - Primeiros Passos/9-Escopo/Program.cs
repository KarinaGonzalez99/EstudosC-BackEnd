using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo {
	internal class Program {
		static void Main(string[] args) {
			// escopo

			Console.WriteLine("Executando Projeto 9 - Escopo");
			Console.WriteLine();


			int idadeJoao = 16;
			bool acompanhado = true;
			string mensagemAdicional;

            if (acompanhado == true)
            {
				mensagemAdicional = "João está acompanhado!";
			}
			else {
				mensagemAdicional = "João não está acompanhado!";
			}

            if (idadeJoao >= 18 && acompanhado == true) {
				Console.WriteLine("Você pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
			else {
				Console.WriteLine("Você não pode entrar");
				Console.WriteLine(mensagemAdicional);
			}

			Console.ReadLine();
		}
	}
}
