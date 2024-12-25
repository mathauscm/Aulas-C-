using System;
class aula19
{
    static void Main()
    {
        int[] num = new int[10];
        for(int i = 0; i < num.Length; i++) 
        {
            num[i] = i;
            //Console.WriteLine(num[i]);
        }
        for(int i = 0; i < num.Length; i++) 
        {
            Console.WriteLine("Valor de num na posição {0}: {1}", i, num[i]);
            /* posição 0 , indicada variavel i valor impresso
             indivado pelo num na posição i */
        }
    }
}