gitusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encadeado {
	internal class Program {
		static void Main(string[] args) {
            // encadeado - break

            Console.WriteLine("Executando projeto 14 - Encadeado");

			for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++) {
                
				for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++) {
                    Console.Write("*");
					if(contadorColuna >= contadorLinha) {
						break;
					}
                }
				Console.WriteLine();
            }

			Console.ReadLine();
        }
	}
}
