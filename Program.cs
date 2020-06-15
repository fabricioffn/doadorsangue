using System;

namespace doadorsangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("digite sua idade");
            idade = Convert.ToInt16(Console.ReadLine());

            if(idade >= 18 &  idade <= 67)
            {
                Console.WriteLine("você pode ser doador");
            }
           else
           {
               Console.WriteLine("você não pode ser doador");
           }
        }
    }
}
