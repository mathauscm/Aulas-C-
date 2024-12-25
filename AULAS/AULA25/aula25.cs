using System;
class aula25
{
    static void Main()
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
    }
    static void dobrar1(ref int valor)
    {
        valor *= 2;
    }
    static void dobrar2(int valor) // sem passagem por referência
    {
        valor *= 2;
    }
}