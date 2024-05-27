using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap6
{
	interface IMensagem
	{
		IEnviador Enviador { get; set; }

		void Envia();

		string Formata();
	}
}
