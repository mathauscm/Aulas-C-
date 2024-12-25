using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    // Construtor sem parâmetros
    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    // Construtor com um parâmetro
    public Jogador(string nome1)
    {
        energia = 100;
        vivo = true;
        nome = nome1;
    }

    // Construtor com dois parâmetros
    public Jogador(string nome1, int e)
    {
        energia = e;
        vivo = e > 0; // Define se o jogador está vivo com base na energia
        nome = nome1;
    }

    // Construtor com três parâmetros
    public Jogador(string nome1, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = nome1;
    }

    public void info()
    {
        Console.WriteLine("Nome jogador....:{0}", nome);
        Console.WriteLine("Energia jogador.:{0}", energia);
        Console.WriteLine("Estado jogador..:{0}\n", vivo);
    }
    public void info(int n)
    {
        Console.WriteLine("Nome jogador....:{0}", nome);
        Console.WriteLine("Energia jogador.:{0}", energia);
        Console.WriteLine("Estado jogador..:{0}\n", vivo);
    }
}

class Aula30
{
    static void Main()
    {
        Jogador j1 = new Jogador(); // Sem parâmetros
        Jogador j2 = new Jogador("Bruno"); // Um parâmetro
        Jogador j3 = new Jogador("Luiz", 100); // Dois parâmetros
        Jogador j4 = new Jogador("Mathaus", 30, true); // Três parâmetros
        Jogador j5 = new Jogador("Ana Márcinha", 0, false); // Três parâmetros

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        j5.info();
    }
}
