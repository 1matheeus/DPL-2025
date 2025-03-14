namespace Cormenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha alguma das opcoes de cor:");
            Console.WriteLine("1) Vermelho");
            Console.WriteLine("2) Verde");
            Console.WriteLine("3) Azul");

            string escolha = Console.ReadLine();

            if (int.TryParse(escolha, out int cor))
            {
                switch (cor)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
                Console.WriteLine("A cor do console foi alterada. Texto de exemplo abaixo:");
                Console.WriteLine("A tecnologia tem evoluído rapidamente, impactando diversos setores e transformando a maneira como interagimos com o mundo. Desde a automação de processos até a inteligência artificial, novas ferramentas surgem constantemente para otimizar tarefas e melhorar a eficiência.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Opcao invalida, digite uma das opcoes acima.");

            }
        }
    }
}
