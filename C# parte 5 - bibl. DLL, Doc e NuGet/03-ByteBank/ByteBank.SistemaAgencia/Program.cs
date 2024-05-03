using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
	internal class Program {
		static void Main(string[] args) {
			// informar datas
			DateTime dataFimPagamento = new DateTime(2024, 06, 03);
			DateTime dataCorrente = DateTime.Now;

			// usamos timespan pra ele setar a data certinho quando subtraido, não tem como fazer de outra forma
			// o proprio programa fala que é tipo timespan
			// dessa forma fica de uma maneira estranha pra se ler por isso vamos 
			TimeSpan diferenca = dataFimPagamento - dataCorrente;

			Console.WriteLine(dataCorrente);
			Console.WriteLine(dataFimPagamento);

			Console.WriteLine();

			Console.WriteLine(diferenca);

			Console.WriteLine();

			// Estou com problemas em instalar qualquer pacote do nuget, irei averiguar o motivo
            Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(diferenca));

            //Console.WriteLine(GetIntervaloDeTempoLegivel(diferenca));
        }


		// pra evitar ficar tendo que setar cada informação iremos usar uma bibliotcea, nuget -> humanizer
		// ferramentas -> gerenciador de pacotes nuget -> console do gerenciador de pacotes
		// -> vai abrir o terminal so colar o codigo da biblioteca do nuget

		//static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan) {
		//	if (timeSpan.Days >= 30) {
		//		int quantidadeDeMeses = timeSpan.Days / 30;
		//		return quantidadeDeMeses + " meses";
		//	}

			//return timeSpan.Days + " dias";
			//}
		}
	}
