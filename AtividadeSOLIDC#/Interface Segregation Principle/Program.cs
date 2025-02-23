class Program
{
    static void Main()
    {
        Console.WriteLine("-------------------------------");
        IVeiculoCarro carro = new Carro("Preto", 1993, 1.9f, 4, 5);
        Console.WriteLine("-------------------------------");
        IVeiculoMoto moto = new Moto("Azul", 2022, 250);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Carro e  Moto Criados com Sucesso!\n");
    }
}