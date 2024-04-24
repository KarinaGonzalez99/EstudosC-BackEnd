using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais {
	internal class Program {
		static void Main(string[] args) {
            // condicionais

            Console.WriteLine("Executando Projeto 7 - Condicionais");
			Console.WriteLine();

			int idadeJoao = 16;
			//int idadeJoao = 26;
			bool acompanhado = true;
			//bool acompanhado = false;

			if (idadeJoao >= 18 ) {
				Console.WriteLine("Você é maior de idade");
			}
			else {
				if(acompanhado == true) {
                    Console.WriteLine("Você é menor de idade, porém está acompanhado");
                } else { 
				Console.WriteLine("Você é menor de idade e não está acompanhado");
				}
			}
			Console.ReadLine();
        }
	}
}
