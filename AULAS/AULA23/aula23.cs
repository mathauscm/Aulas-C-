using System;

class aula23 {
    static void Main() {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { {11, 22, 0, 44, 55}, {66, 77, 88, 99, 0} };

        Random random = new Random(); // para gerar numeros aleatórios
        for (int i = 0; i < vetor1.Length; i++) {
            vetor1[i] = random.Next(50); 
            // Next() retorna valor inteiro qualquer
            // Next(50) 0-49 chamado valor maximo ou (50-100) valor minimo e maximo
        }

        Console.WriteLine("Elementos do vetor1"); // print vetor1 dos numeros Random
        foreach (int n in vetor1) {
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor);
        Console.WriteLine("BinarySearch"); // retorna a posição elemento procurado
        int procurado = 33; // se valor procurado não estiver no arrray retorna -1
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("-------------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2) {
            Console.WriteLine(n);
        }

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long índice); TRATA-SE DE OBJECT sendo necessario converter
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor);
        Console.WriteLine("IndexOf"); // retona o valor indicado no segundo parametro (arr, val)
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array,valor);
        Console.WriteLine("LastIndexOf"); //ultimo valor
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 3: {0}", indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        Array.Reverse(vetor1); // inverte ordem elementos
        foreach (int n in vetor1) { // 12345 -> 54321
            Console.WriteLine(n);
        }

        //public void SetValue(object valor, long pos);
        vetor2.SetValue(99, 0); //definir valor em posição do vetor
        for (int i = 0; i < vetor2.Length; i++) {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2) {
            Console.WriteLine(n);
        }

        //public static void Sort(array);
        Array.Sort(vetor1); // metodo para ordenar em ordem crescente os elementos array
        Array.Sort(vetor2); // ordem decrescente pode usar o sort, depois um reverse mode
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1) {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach (int n in vetor2) {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach (int n in vetor3) {
            Console.WriteLine(n);
        }
    }
}
