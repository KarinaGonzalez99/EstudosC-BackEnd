using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao {
	partial class Program {
		static void EscritaBinaria() {
			using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
			// o binary é feito pra produzir a representação de maneira binaria, por conta do espaço ocvupado de 1byte o true e falso, e o numero inteiro usa 4bytes
			using (var escritor = new BinaryWriter(fs)) {
				escritor.Write(456); // Número da Agência
				escritor.Write(546544); // Número da conta
				escritor.Write(4000.50); // Saldo
				escritor.Write("Gustavo Braga");
			}
		}

		// da maneira de cima ficamos com um formato estranho, e então temos que criar um metodo que faça a leitura deste arquivo em formaturo binario
		static void LeituraBinaria() {
			using (var fs = new FileStream("contaCorrente.txt", FileMode.Open)) 
			using (var leitor = new BinaryReader(fs)) {
				var agencia = leitor.ReadInt32();
				var numeroConta = leitor.ReadInt32();
				var saldo = leitor.ReadDouble();
				var titular = leitor.ReadString();

				Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
			}
		}

	}
}
