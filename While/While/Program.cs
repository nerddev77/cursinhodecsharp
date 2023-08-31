namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Nerd", "Dev", "Curso de C#", "Formação", "Node", "PHP" };

            for (int contador = 0 ; contador < palavras.Length ; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }
            Console.WriteLine("==========================");
            for (int contador2 = palavras.Length - 1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }



            /*
            foreach(string palavra in palavras) // Para cada palavra no ARRAY palavras, repita o bloco de código
            {
                Console.WriteLine("FOREACH RODANDO");
                Console.WriteLine(palavra);
            }
            */


           /* int contador = 0;
            while(contador < 10)
            {
                Console.WriteLine("Rodando o While!");
                contador++;
            } 

            // DO WHILE
            // Mesmo que a condição seja uma mentira, ele vai reproduzir pelo menos uma vez!

            do
            {
                Console.WriteLine("Do While!");   
            } while(1000 < 10);
           */


            Console.WriteLine("Fim da linha meu nobre!");
            Console.ReadLine();
        }
    }
}