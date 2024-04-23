using System;

namespace _2_CriandoVariaveis {
	class Program {
		static void Main(string[] args) {
            //criando variaveis
            Console.WriteLine("Executando projeto 2 - Criando Variaveis ");
			int idade = 25;
			Console.WriteLine(idade);

			idade = idade + 1;
            Console.WriteLine(idade);
            Console.WriteLine($"Sua idade é {idade} anos!");

        }
	}
}