using System;

class Veiculo // Classe Base
{
    private int rodas;
    public int valMax;
    private bool ligado;

    public Veiculo(int rodas) // Construtor na classe base, esse construtor aceita 1 arg, se for 0 ele não compila
    {
        this.rodas = rodas;
    }

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
        return(ligado? "Sim" : "Não"); //operador ternario
        
    }
    public int getRodas() // criação do metodo para acessa a variavel private
    {
        return rodas;
    }
    public void setRodas(int rodas)
    {
        if(rodas <0)
        {
            this.rodas = 0;
        }else if
        {
            if (rodas > 40)
            {
                this.rodas = 40;
            }
        }
    }

}
class Carro : Veiculo // Carro (derivada) : Veiculo (Base)
{
    public string nome;
    public string cor;

    
    //inicialização do construtor da classe base, 
    public Carro(string nome, string cor):base(4) // :base4 está passando arg para  
    {
        desligar();
        
        valMax = 120; 
        this.nome = nome;
        this.cor = cor; 

    }
}

class CarroCombate:Carro
{
    public int municao;
    public CarroCombate():base("Carro de Combate", "Verde")
    {
        municao = 100;
    }
}

class Aula35
{
    public static void Main()
    {
        Carro c1 = new Carro("Rapidão", "Vermelho");

        c1.ligar();

        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.getRodas());
        Console.WriteLine("Velocidade Max.: {0}", c1.valMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado()); // chamando um método usa ()

    }
}