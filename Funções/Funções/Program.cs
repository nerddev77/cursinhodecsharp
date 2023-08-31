namespace Funcoes
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            GerarPreco(60, "Curso de C#");
            ExibirMsg();
            ExibirMsg();
            ExibirMsg();
            
            int soma1 = Somar(1,20,4);
            */
            string[] produtos = new string[5]
            {
                "Sea of Tghieves", //0
                "Minecraft", //1
                "FIFA", //2
                "Half-Life", //3
                "Portal" //4
            };

            Console.WriteLine(produtos[1]);

            Console.ReadLine(); 
        }
        static void ExibirMsg()
        {
            Console.WriteLine("CSharp é show de bola");
            Console.WriteLine("Estou usando uma função!");
        }

        static void GerarPreco(int preco, string nome)
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine(preco);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}