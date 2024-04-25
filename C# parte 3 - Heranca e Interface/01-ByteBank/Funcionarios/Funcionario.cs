using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios {
	public class Funcionario {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // 3 - Gerente de conta correte
        // 4 - Coordenador
        // N - ...
        //private int _tipo;

        public static int TotalDeFuncionarios {  get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } // havia colocado private, mas isso impediria a atualização dos valores, pra isso usamos o protect

        // metodo de quantificação de funcionarios
        public Funcionario(string cpf, double salario) {
            Console.WriteLine("CRIANDO FUNCIONARIO");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        // removemos porque não fazia sentido pra cada funcionario criar um tipo e definiri externamente, o ideal foi criar um classe pra cada
        //public Funcionario(int tipo) {
        //    _tipo = tipo;
        //}


        // requisito do cliente - aumentar salario com base em % em cima do salario
        public virtual void AumentarSalario() {
            Salario *= 1.1; // igual a salario = salario + (salario * 0.1);
        }

        // metodo de retorno do processo de bonificação do funcionario de maneira virtual (podendo ser sobreescrito)
        public virtual double GetBonificacao() { // por ter um processamento é indicado o uso de
            //if(_tipo == 1) { // uma hora teremos varios if, por isso se opta por criar outra classe
            //    return Salario;
            //}
            
            return Salario * 0.10;
        }

    }
}
