using _01_DesingPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap4
{
	interface IExpressao
	{
		int Avalia();
		void Aceita(Impressora impressora);
	}
}
