using System;

public class Carro : Veiculo
{
    private int Assentos { get; set; }
    private int Portas { get; set; }

    public Carro(string cor, int ano, double motor, int portas, int assentos)
        : base(cor, ano, motor)
    {
        Assentos = assentos;
        Portas = portas;
    }

    public override void CriarVeiculo()
    {
        Console.WriteLine($"Criando um Carro {Cor}, {Ano}, {Motor}, {Portas} portas, {Assentos} assentos.");
        LigarMotor();
    }
}