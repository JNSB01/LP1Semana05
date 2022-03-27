using System;

namespace MyTestOfRandoms
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random nr = new Random();
            int soma = 0;

            Console.WriteLine("Por favor insira os dados a ser lançados");

            int dados = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dados; i++)
            {
                soma += nr.Next(1,6);
            }

            Console.WriteLine(soma);
        }
    }
}
