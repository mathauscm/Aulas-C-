using System;
class Produto
{
    public int ProdCod;
    public string ProdNome;
    public double ProdPreco;
    public int ProdQtd;

}
class Principal
{
    public static void Main()
    {
        Produto prod1 = new Produto(); // objeto da classe produto
        prod1.ProdCod = 111;
        prod1.ProdNome = "Caneta";
        prod1.ProdPreco = 20;
        prod1.ProdQtd = 20;
        Console.Clear();
        Console.WriteLine(
            "Código do produto: {0}\n" +
            "Nome do produto: {1}\n" +
            "Preço do produto: {2}\n" +
            "Qtde. em estoque: {3}\n", 
            prod1.ProdCod, 
            prod1.ProdNome, 
            prod1.ProdPreco, 
            prod1.ProdQtd);
        //Console.WriteLine("Código do produto: {0}", prod1.ProdCod);
        //Console.WriteLine("Nome do produto: {0}", prod1.ProdNome);
        //Console.WriteLine("Preço do produto: {0}", prod1.ProdPreco);
        //Console.WriteLine("Qtde. em estoque: {0}", prod1.ProdQtd);
    }
}