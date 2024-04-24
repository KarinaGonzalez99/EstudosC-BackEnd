using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank {
	internal class Program {
		static void Main(string[] args) {
            // objeto

            Console.WriteLine("Executando projeto 3");
            ContaCorrente contaDaGabriela = new ContaCorrente();
			contaDaGabriela.titular = "Gabriela";
			contaDaGabriela.agencia = 863;
			contaDaGabriela.numero = 863452;

			ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
			contaDaGabrielaCosta.titular = "Gabriela";
			contaDaGabrielaCosta.agencia = 863;
			contaDaGabrielaCosta.numero = 863452;

			// resultado false, um objeto não é igual ao outro (pois na verdade são referencias) - cada um tem um endereço de memoria
			Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // igualdade de tipo de referencia

			// resultado true
			int idade = 27;
			int idadeMaisUmaVez = 27;
            Console.WriteLine(idade == idadeMaisUmaVez);// igualdade de tipo de valor

			// resultado true
			contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

			// como definido anteriormente a igualdade entre ambos a partir disso a alteração de uma afeta a outra
			contaDaGabriela.saldo = 3000;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);


        }
	}
}
