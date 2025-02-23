public class Moto : IVeiculoMoto
{
    private string cor = string.Empty;
    private int ano;
    private float motor;

    public Moto(string cor, int ano, float motor)
    {
        ConfigureMoto(cor, ano, motor);
    }

    public void ConfigureMoto(string cor, int ano, float motor)
    {
        this.cor = cor;
        this.ano = ano;
        this.motor = motor;
        Console.WriteLine($"Criando Moto: Ano {ano}, Cor {cor}, Motor {motor} cilindradas.");
        LigaVeiculo();
    }

    public void LigaVeiculo()
    {
        Console.WriteLine("Ligando a Moto...");
    }
}