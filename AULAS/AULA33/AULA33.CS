using System;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 0;
    }
    public int getEnergia()
    {
        return energia;
    }
    public string getNome()
    {
        return nome;
    }
    public void setEnergia(int e)
    {
        if (e < 0)
        {
            if(energia + e < 0)
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        else if (e > 0)
        {
            if(energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
    }

}
class Aula33
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Mathaus");

        //j1.setEnergia(-130);
        j1.setEnergia(99);
        j1.setEnergia(10);
        
        Console.WriteLine("Nome: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}