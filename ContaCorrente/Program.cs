// Classe para representar uma movimentação de crédito ou débito
class Movimentacao
{
    public decimal Valor { get; set; }
    public bool Credito { get; set; }

    public Movimentacao(decimal valor, bool credito)
    {
        Valor = valor;
        Credito = credito;
    }
}

// Classe para representar uma conta corrente
class ContaCorrente
{
    public int Numero { get; set; }
    public decimal Saldo { get; set; }
    public bool Especial { get; set; }
    public decimal Limite { get; set; }
    public List<Movimentacao> Movimentacoes { get; set; }

    public ContaCorrente(int numero, decimal saldo, bool especial, decimal limite)
    {
        Numero = numero;
        Saldo = saldo;
        Especial = especial;
        Limite = limite;
        Movimentacoes = new List<Movimentacao>();
    }

    // Método para realizar um saque
    public void Sacar(decimal valor)
    {
        decimal limiteSaque = Limite + Saldo;

        if (valor <= limiteSaque)
        {
            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(valor, false));
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de saque excede o limite disponível.");
        }
    }

    // Método para realizar um depósito
    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Movimentacoes.Add(new Movimentacao(valor, true));
        Console.WriteLine("Depósito realizado com sucesso!");
    }

    // Método para visualizar o saldo
    public void VisualizarSaldo()
    {
        Console.WriteLine("Saldo atual: R$" + Saldo);
    }

    // Método para visualizar o extrato
    public void VisualizarExtrato()
    {
        Console.WriteLine("Extrato da conta corrente " + Numero + ":");
        foreach (var movimentacao in Movimentacoes)
        {
            Console.WriteLine("Valor: R$" + movimentacao.Valor + " | Tipo: " + (movimentacao.Credito ? "Crédito" : "Débito"));
        }
    }

    // Método para transferir valor para outra conta corrente
    public void Transferir(decimal valor, ContaCorrente contaDestino)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Transferência realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para transferência.");
        }
    }
}