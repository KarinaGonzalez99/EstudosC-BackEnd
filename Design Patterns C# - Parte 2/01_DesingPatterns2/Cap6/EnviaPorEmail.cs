using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap6
{
	class EnviaPorEmail : IEnviador
	{
		public void Envia(IMensagem mensagem)
		{
            Console.WriteLine("Enviando a mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
	}
}
