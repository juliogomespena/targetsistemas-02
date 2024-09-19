Console.Write("Informe um número: ");

if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (ChecarFibonacci(numero))
    {
        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }
}
else
{
    Console.WriteLine("Por favor, informe um número válido.");
}

bool ChecarFibonacci(int numero)
{
    if (numero < 0) return false;
    
    int a = 0;
    int b = 1;
    
    while (a < numero)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }

    return a == numero;
}
