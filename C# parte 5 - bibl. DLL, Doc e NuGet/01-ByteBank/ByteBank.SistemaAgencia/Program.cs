using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRA PODER FAZER REFERENCIA DAS CLASSES QUE ESTÃO NO OUTRO ARQUIVO VAMOS EM REFERENCIAS, ADICIONAR REFERENCIA ...
            ContaCorrente conta = new ContaCorrente(545, 67542);

            new ContaCorrente(123, 456521);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
