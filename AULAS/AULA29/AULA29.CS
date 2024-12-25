using System;

public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(string nome1)
    {
        energia = 100;
        vivo = true;
        nome = nome1;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi destuido", nome);
    }

}
class Aula29
{
    static void Main()
    {

       string nome2;
       Console.WriteLine("Digite o nome do segundo Jogador: ");
       nome2 = Console.ReadLine();

       Jogador j1 = new Jogador("Mathaus");
       Jogador j2 = new Jogador(nome2);

       j1.energia = 50;    

       //Console.WriteLine($"Energia do Jogador 1: {j1.energia}");
       Console.WriteLine("Energia do Jogador 1: {0} {1}", j1.nome, j1.energia);
       Console.WriteLine("Energia do Jogador 2: {0} {1}", j2.nome, j2.energia);

    }
    
}