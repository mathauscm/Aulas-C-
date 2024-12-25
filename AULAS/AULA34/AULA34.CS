using System;

class Veiculo // Classe Base
{
    public int rodas;
    public int valMax;
    private bool ligado;

    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;

    }
    public string getLigado()
    {
        if(ligado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }
    }
}
class Carro : Veiculo // Carro (derivada) : Veiculo (Base)
{
    public string nome;
    public string cor;
    public Carro(string nome, string cor)//cor passagem feita como parametro
    {
        desligar();
        rodas = 4;
        valMax = 120; 
        this.nome = nome;
        this.cor = cor; 

    }
}

class Aula34
{
    public static void Main()
    {
        Carro c1 = new Carro("Rapidão", "Vermelho");
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.rodas);
        Console.WriteLine("Velocidade Max.: {0}", c1.valMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado()); // chamando um método usa ()

    }
}