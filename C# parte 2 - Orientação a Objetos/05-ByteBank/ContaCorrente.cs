/*using _05_ByteBank;*/ // Sabe-se que o cliente é uma classe devido a isso.. se nao ficaria _05_ByteBank.Cliente
// nao precisa mais disso pois já definimos o nome do nosso space, e com isso é o mesmo.

namespace _05_ByteBank {

public class ContaCorrente {
	public Cliente titular; // foi chamado nossa outra classe aqui dentro
	public int agencia;
	public int numero;
	public double saldo = 1000;

	 public bool Sacar(double valor) {
		if(this.saldo < 100) {
			return false;
		} else {
			this.saldo -= valor;
			return true;
		}
	}

	// metodo sem retorno
	public void Depositar(double valor) {
		this.saldo += valor;
	}

	public bool Transferir(double valor, ContaCorrente contaDestino) {
		if(this.saldo < valor) {
			return false;
		} else {
			this.saldo -= valor;
			contaDestino.Depositar(valor);
			return true;
		}
	}

}
}