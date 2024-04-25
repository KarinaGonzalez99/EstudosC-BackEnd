using _02_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
	public class ParceiroComercial : IAutenticavel {
		public string Senha { get; set; }
		public bool Autenticar(string senha) {
			return Senha == senha;
		}
	}
}
