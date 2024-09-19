//Solicita numero
Console.Write("Informe um número: ");

//Verifica se o valor informado é um número
if (int.TryParse(Console.ReadLine(), out int numero))
{
    //Verifica se o número informado pertence a sequência de Fibonacci
    if (ChecarFibonacci(numero))
    {
        //Exibe mensagem informando que o número pertence a sequência de Fibonacci
        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
    }
    else
    {
        //Exibe mensagem informando que o número não pertence a sequência de Fibonacci
        Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }
}
else
{
    //Exibe mensagem informando que o valor informado não é um número
    Console.WriteLine("Por favor, informe um número válido.");
}

//Função para verificar se o número informado pertence a sequência de Fibonacci
bool ChecarFibonacci(int numero)
{
    //Verifica se o número informado é menor que 0
    if (numero < 0) return false;

    //Declaração de variáveis
    int a = 0;
    int b = 1;

    //Loop para verificar se o número informado pertence a sequência de Fibonacci
    while (a < numero)
    {
        //Troca os valores das variáveis. Cria uma variável temporária para guardar o valor de 'A' anterior. Transforma A em B ( proximo numero ). Faz a soma de B com o valor temporário (A anterior);
        int temp = a;
        a = b;
        b = temp + b;
    }

    //Retorna se o número informado pertence a sequência de Fibonacci
    return a == numero;
}
