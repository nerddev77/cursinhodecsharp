using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            /*
            int segundaGuerraMundial = 1942;
            string corFavorita = "Verde";
            float velocidadeF1 = 250.34f;
            bool aconteceuSegundaGuerra = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(aconteceuSegundaGuerra);
            */
            Console.WriteLine("Boa noite, qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}
