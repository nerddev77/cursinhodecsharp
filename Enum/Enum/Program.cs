namespace Enum
{
    class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho}

        enum Opcao { Criar = 1, Deletar = 2, Editar = 3, Listar = 4, Atualizar = 5 }

        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você me criou!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETADO");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("EDITADO!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }

            Console.ReadLine();
        }
    }
}