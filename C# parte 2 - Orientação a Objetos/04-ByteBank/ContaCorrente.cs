public class ContaCorrente {
	public string titular;
	public int agencia;
	public int numero;
	public double saldo = 1000;

	 public bool Sacar(double valor) { // função com letra maiuscula, verbo no infinitivo
		if(this.saldo < 100) { // this é usado pra referenciar o valor que vai ser dado posteriormente
			return false;
		} else {
			this.saldo -= valor;
			return true;
		}
	}

	// metodo sem retorno
	public void Depositar(double valor) { // void siginifica que nao tem retorno
		this.saldo += valor;
	}

	// metodo com retorno
	public bool Transferir(double valor, ContaCorrente contaDestino) { // ContaCorrente usado pois já definimos o objeto com tudo dentro
		if(this.saldo < valor) {
			return false;
		} else {
			this.saldo -= valor;
			contaDestino.Depositar(valor);
			return true;
		}
	}
}