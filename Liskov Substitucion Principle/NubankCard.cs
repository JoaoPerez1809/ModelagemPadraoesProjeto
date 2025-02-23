using System;

public abstract class NubankCard : IInstrumentoPagamento
{
    public void ColetarPagamento()
    {
        Console.WriteLine("Pagamento Realizado");
    }

    public virtual void Validacao()
    {
        Console.WriteLine("Validação básica do cartão...");
    }
}