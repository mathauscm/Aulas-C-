using System;
class aula25
{
    static void Main()
    {
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 3;
        quoc = divide(divid, divis, out rest);

        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divid, divis, quoc, rest);

    }
    static int divide( int dividendo, int divisor, out int resto)
    {
        int quociente;
        resto = dividendo % divisor; // agrumento de saida devido o uso do out
        quociente = dividendo / divisor;
        return quociente;

    }
}