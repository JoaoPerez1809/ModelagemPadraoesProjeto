using System;

public class Moto : Veiculo
{
    public Moto(string cor, int ano, double motor)
        : base(cor, ano, motor) { }

    public override void CriarVeiculo()
    {
        Console.WriteLine($"Criando uma Moto {Cor}, {Ano}, {Motor} cilindradas.");
        LigarMotor();
    }
}