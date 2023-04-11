using System.Collections;

namespace ContaC
{
    namespace ContaCorrente.ConsoleApp1
    {
        public class ContaCorrente
        {
            public string nome;
            public int saldo, numeroConta, limite, contador = 0;
            public bool ehEspecial;
            public string opercao;
            public int valorOperacao;
            public ArrayList operacoesRealizadas = new ArrayList();

            public ContaCorrente()
            {

            }
            public ContaCorrente(string nome, int saldo, int numeroConta, int limite, bool ehEspecial)
            {
                this.nome = nome;
                this.saldo = saldo;
                this.numeroConta = numeroConta;
                this.limite = limite;
                this.ehEspecial = ehEspecial;
            }


            private void AdicionarOperacaoList(int quantidade, string nomeOperacao)
            {
                ContaCorrente movimentacao = new ContaCorrente
                {
                    opercao = nomeOperacao + " " + quantidade
                };

                operacoesRealizadas.Add(movimentacao.opercao);
            }

            public void Deposito(int quantidade)
            {
                this.saldo += quantidade;

                AdicionarOperacaoList(quantidade, "Deposito +");
            }

            public void Saque(int quantidade)
            {

                if (saldo < quantidade)
                    return;
                saldo -= quantidade;

                AdicionarOperacaoList(quantidade, "Saque -");
            }

            public int VizualizarSaldo()
            {
                return this.saldo;
            }

            public void Tranferencia(int quantidade, ContaCorrente entraValor)
            {
                if (saldo < quantidade)
                    return;

                saldo -= quantidade;

                entraValor.saldo += quantidade;

                AdicionarOperacaoList(quantidade, "Tranferencia -");

                entraValor.AdicionarOperacaoList(quantidade, "Tranferencia +");



            }

            public void MostrarEstrato()
            {
                foreach (var item in operacoesRealizadas)
                {
                    Console.WriteLine(item);
                }
            }










        }
    }