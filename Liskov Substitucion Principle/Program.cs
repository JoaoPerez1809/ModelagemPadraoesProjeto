using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Cartão de Credito");
        IInstrumentoPagamento cartaoCredito = new CreditCard();
        cartaoCredito.Validacao();
        cartaoCredito.ColetarPagamento();

        Console.WriteLine("----------------------------");

        Console.WriteLine("Cartão de Debito");
        IInstrumentoPagamento cartaoDebito = new DebitCard();
        cartaoDebito.Validacao();
        cartaoDebito.ColetarPagamento();
        
        Console.WriteLine("----------------------------");

        IInstrumentoPagamento cartaoRewards = new NubankRewards();
        cartaoRewards.Validacao();
        cartaoRewards.ColetarPagamento();

        Console.WriteLine("----------------------------");

        IPagamentoComRecompensa rewards = new NubankRewards();
        rewards.AtualizarPontuacao(50);
        Console.WriteLine("----------------------------");
    }
}