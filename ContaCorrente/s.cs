using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso
        ContaCorrente conta1 = new ContaCorrente(12345, 1000, false, 500);
        ContaCorrente conta2 = new ContaCorrente(67890, 500, false, 1000);

        conta1.Depositar(200);
        conta1.Sacar(150);
        conta1.Transferir(300, conta2);

        conta1.VisualizarSaldo();
        conta1.VisualizarExtrato();
        conta2.VisualizarSaldo();
        conta2.VisualizarExtrato();
    }
}