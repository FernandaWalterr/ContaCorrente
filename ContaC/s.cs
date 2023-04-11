using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp1
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente("Felipe Maines", 1000, 101, 0, false);
            var conta2 = new ContaCorrente("Pedro Marto", 1000, 200, 0, true);

            conta1.Saque(200);

            conta1.Deposito(300);

            conta1.Deposito(500);

            conta1.Saque(200);

            conta2.Tranferencia(400, conta1);

            conta2.Saque(500);

            Console.WriteLine("\n\nConta 2 Extrato:\n");
            Console.WriteLine("Valor inicial 1000");
            conta2.MostrarEstrato();
            Console.WriteLine("Valor Final: " + conta2.VizualizarSaldo());

            Console.WriteLine("-----------------------------------------------------------------------------------\n\n");


            Console.WriteLine("Conta 1 Extrato:\n");
            Console.WriteLine("Valor inicial 1000");
            conta1.MostrarEstrato();
            Console.WriteLine("Valor Final " + conta1.VizualizarSaldo());


        }
    }
}