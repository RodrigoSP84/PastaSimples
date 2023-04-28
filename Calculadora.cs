using System;

class Program
{
    public static void Main(string[] args)
    {
        double gasolina, alcool, soma, parar;
        while (true)
        {
            Console.Write("Digite o valor da gasolina: ");
            gasolina = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do álcool: ");
            alcool = double.Parse(Console.ReadLine());
            soma = alcool / gasolina;
            if (soma == 0.70)
            {
                Console.WriteLine("Tanto faz abastecer com álcool ou gasolina. ");
            }
            if (soma > 0.70)
            {
                Console.WriteLine("Abasteça com gasolina. ");
            }
            if (soma < 0.70)
            {
                Console.WriteLine("Abasteça com álcool. ");
            }
            Console.WriteLine("Digite 0 para continuar, e 1 para finalizar.");
            parar = double.Parse(Console.ReadLine());
            if (parar == 0)
            {
              
            }
            else if (parar == 1)
            {
            break;  
            } 
        }
    }
}