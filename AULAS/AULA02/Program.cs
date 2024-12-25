using System;

namespace AULA02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mathaus!");
            if(args.GetLength(0)>0){
                Console.WriteLine(args.GetValue(0));
            }        
            
        }
    }
}
