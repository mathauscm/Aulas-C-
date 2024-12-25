using System;

class Program
{
    static void Main()
    {
        double resultadoDivisao = Divisao(10.5, 2.5); // Chamando o método Divisao
        Console.WriteLine("O resultado da divisão é {0}", resultadoDivisao);
    }

    static double Divisao(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
            return 0; // Retorna 0 para evitar divisão por zero
        }
        return x / y;
    }
}
```

### Equivalência com `def` em Python

Em Python, você define funções usando a palavra-chave `def`, como no exemplo abaixo:

```python
def soma(x, y):
    return x + y

resultado = soma(10, 20)
print(f"A soma de 10 e 20 é {resultado}")

