namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 2;

            // &&(E/AND)
            // || (OU/OR)
            // Se a pessoa for MULHER && IDADE >= 25 -> Entra na festa de graça



            if (a < b && a > c) 
            {
                Console.WriteLine("Verdadeiro");
            }
            else if (a > c)
                {
                Console.WriteLine("Executou Else If");
            }
            else
            {
                Console.WriteLine("É mentira");
            }
            Console.ReadLine();
        }
    }
}