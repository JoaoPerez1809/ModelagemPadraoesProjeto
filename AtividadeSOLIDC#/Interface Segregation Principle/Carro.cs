public class Carro : IVeiculoCarro
{
    private string cor = string.Empty;
    private int ano, assentos, portas;
    private float motor;

    public Carro(string cor, int ano, float motor, int assentos, int portas)
    {
        ConfigureCarro(cor, ano, motor, assentos, portas);
    }

    public void ConfigureCarro(string cor, int ano, float motor,  int portas, int assentos)
    {
        this.cor = cor;
        this.ano = ano;
        this.motor = motor;
        this.assentos = assentos;
        this.portas = portas;
        Console.WriteLine($" Criando Carro: Ano {ano}, Cor {cor}, Motor |{motor}|, {portas} portas, {assentos} assentos.");
        LigaVeiculo();
    }

    public void LigaVeiculo()
    {
        Console.WriteLine(" Ligando o Carro...");
    }
}