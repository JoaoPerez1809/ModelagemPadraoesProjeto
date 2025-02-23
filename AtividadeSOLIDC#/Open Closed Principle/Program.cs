class Program
{
    static void Main()
    {
        Veiculo carro = new Carro("Preto", 1993, 1.9, 4, 5);
        carro.CriarVeiculo();

        Veiculo moto = new Moto("Preta", 2023, 600);
        moto.CriarVeiculo();
    }
}