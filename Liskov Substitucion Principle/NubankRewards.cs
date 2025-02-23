using System;

public class NubankRewards : NubankCard, IPagamentoComRecompensa
{
    private int pontos;

    public NubankRewards(){
        pontos = 0;
    }
    public override void Validacao()
    {
        Console.WriteLine("Validando cliente no programa de recompensas...");
        Console.WriteLine("Cliente apto a ganhar pontos.");
    }

    public void AtualizarPontuacao(int valor)
    {
        pontos = valor;
        Console.WriteLine($" {valor} Pontos adicionados! Pontuação atualizada com sucesso!");
        Console.WriteLine($"Pontos totais {pontos} pontos.");
    }
}