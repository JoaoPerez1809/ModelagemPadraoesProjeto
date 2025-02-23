using System;

public abstract class Veiculo
{
    protected string Cor { get; set; }
    protected int Ano { get; set; }
    protected double Motor { get; set; }

    public Veiculo(string cor, int ano, double motor)
    {
        Cor = cor;
        Ano = ano;
        Motor = motor;
    }

    public abstract void CriarVeiculo();

    protected void LigarMotor()
    {
        Console.WriteLine("Ligando os motores.");
    }
}