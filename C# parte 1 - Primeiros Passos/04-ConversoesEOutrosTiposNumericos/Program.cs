using System;

namespace _4_ConversoesEOutrosTiposNumericos {
	class Program {
		static void Main(string[] args) {
			//conversoes e outros tipos numericos
			Console.WriteLine("Executando projeto 4 - Conversões e outros tipos numericos ");

			// double = numero quebrado
			double salario;
			salario = 1200.50;
            Console.WriteLine(salario);

			// não funciona se fizesse salarioEmInteiro = salario, porque um é int e o outro é double pra isso devemos usar uma conversao casting, ou seja, tipar antes o item já tipado
            int salarioEmInteiro;
			salarioEmInteiro = (int) salario; // conversão com casting, mudando qual o tipo
			Console.WriteLine(salarioEmInteiro);

			// int é limitado entre - e + em 32bit, ele usa menos memoria, sendo o mais utilizado
			int idade;
			idade = 26;
			Console.WriteLine(idade);
			//idade = 130000000000000000000; // maior do que o int suporta(+32bit)

			// pelo int ser mto limitaod se usa o long, que suporta - e + até 64 bit, porem acaba pegando muita memoria
			long maiorQInt;
			maiorQInt = 130000000000000000; // maior que o int suporta 64bit
			Console.WriteLine(maiorQInt);

			// short suporta - e + até 16bit, sendo menor que o int
			short quantidadeProdutos;
			quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

			// suporta menos precisão depois da virgula que o double
			float altura;
			altura = 1.80f; // por não ser usual o uso do float e ele sempre mandar como um double, pra ser considerado um float, se tem a necessidade do uso do sufixo f, mostrando nao ser um erro de digitação
			Console.WriteLine(altura);
        }
	}
}
