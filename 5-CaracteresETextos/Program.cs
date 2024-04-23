using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//obs pessoal: percebi que quando iniciava um projeto não selecionava a opção correta de console do .netframework
// por isso meus antigos projetos não tinham console.readline e eu achei que não precisava mais
// percebi a partir desse projeto que eu tinha aberto os projetos de maneira errada e a partir daqui irei fazer da forma correta S2

namespace _5_CaractereETexto {
	internal class Program {
		static void Main(string[] args) {
            // caracteres e textos
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
			Console.WriteLine();

			// character : so pode ter um caracter
			char primeiraLetra = 'a'; // aspas simples
            Console.WriteLine(primeiraLetra);

			//primeiraLetra = 65; // nao funciona por ter mais de 16bit
			primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);
			
			// com isso percebe-se que existe um table, respeita a ascii table
			primeiraLetra = (char) (primeiraLetra + 1);
			Console.WriteLine(primeiraLetra);

			// 65 = A; 66 = B; 97 = a...
			primeiraLetra = (char)97;
			Console.WriteLine(primeiraLetra);

			Console.WriteLine();

			// string usada pra representação de textos
			string titulo = "Estudo de C# com base no curso de tecnologia da Alura";
            Console.WriteLine(titulo);

			// apenas concatena
			titulo = "String com um mais depois das chaves é considerado concatenação " + 2020 + " por exemplo esse 2020 foi um numero int";
			Console.WriteLine(titulo);

			Console.WriteLine();

			// lista mesma linha
			string cursosProgramação = " - .NET" +
				" - Java" +
				" - Javascript";
			Console.WriteLine(cursosProgramação);

            Console.WriteLine();

            // lista linha separada
            cursosProgramação = 
@"- .NET
- Java
- Javascript";
			Console.WriteLine(cursosProgramação);

			Console.ReadLine();
        }
	}
}
