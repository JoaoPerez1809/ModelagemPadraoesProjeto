using System;

public class CreditCard : NubankCard
{
    public override void Validacao()
    {
        Console.WriteLine("Validando limite...");
        Console.WriteLine("Limite Ok");
    }
}