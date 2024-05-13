using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos {
	internal class AutenticacaoHelper { // internal é uma caracteristica interna, visiel dentro do projeto(pasta), mas não é visto externametne.
										// Quando uma classe não é declarada, podemos deduzir que ela é interna 


		// vamos centralizar a logica de senha sem ter que ficar replicando
		public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa) {
			return senhaVerdadeira == senhaTentativa;
		}

	}
}
