using System;

public class DebitCard : NubankCard
{
    public override void Validacao()
    {
        Console.WriteLine("Validando saldo...");
        Console.WriteLine("Saldo disponível");
    }
}