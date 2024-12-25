using System;
class aula24{
    static void Main(){
        
        int v1,v2,r;
        Console.WriteLine("Digite o valor 1: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor 2");
        v2 = int.Parse(Console.ReadLine());
        r = somar(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}" , v1, v2, r);
        //Console.WriteLine("A soma de {0} e {1} é: {2}" , v1, v2, somar(v1,v2);   

    }

    static int somar(int n1, int n2){

        int res = n1+n2;
        return res;
       
    }

}