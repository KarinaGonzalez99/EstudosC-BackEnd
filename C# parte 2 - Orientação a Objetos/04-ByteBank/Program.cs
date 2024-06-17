using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank {
	internal class Program {
		static void Main(string[] args) {
            // função
            Console.WriteLine("Executando Projeto 4");
            Console.WriteLine();

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine();
            //sacar
            Console.WriteLine("Sacar");
			Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Sacar(25);
			Console.WriteLine(contaDoBruno.saldo);
			contaDoBruno.Sacar(25);
			Console.WriteLine(contaDoBruno.saldo);
			bool resultadoSaque = contaDoBruno.Sacar(500);
			Console.WriteLine(contaDoBruno.saldo); 
			Console.WriteLine(resultadoSaque); // true + de 100
			contaDoBruno.Sacar(375);
			Console.WriteLine(contaDoBruno.saldo);
			resultadoSaque = contaDoBruno.Sacar(10); 
			Console.WriteLine(resultadoSaque); // false - de 100

            Console.WriteLine();
            //depositar
            Console.WriteLine("Depositar");
            contaDoBruno.Depositar(500);
			Console.WriteLine(contaDoBruno.saldo);

			Console.WriteLine();
			// transferencia
			Console.WriteLine("Transferência");
			ContaCorrente contaDaGabriea =  new ContaCorrente();
			contaDaGabriea.titular = "Gabriela";
			Console.WriteLine($"Saldo anterior do Bruno: {contaDoBruno.saldo}");
			Console.WriteLine($"Saldo anterior da Gabriela: {contaDaGabriea.saldo}");

			contaDoBruno.Transferir(200, contaDaGabriea);
			Console.WriteLine($"Saldo do Bruno: R${contaDoBruno.saldo}");
			Console.WriteLine($"Saldo da Gabriela: R${contaDaGabriea.saldo}");

			Console.WriteLine();
			bool resultadoTranseferencia = contaDaGabriea.Transferir(25, contaDoBruno);
			Console.WriteLine($"Resultado transferencia {resultadoTranseferencia}");
		}
	}
}
