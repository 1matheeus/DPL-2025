namespace nprimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Insira um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (Primo(num))
            {
                Console.WriteLine($"O número inserido: {num} é primo");
            }
            else
            {
                Console.WriteLine($"O número inserido: {num} não é primo");
            }
        }
        static bool Primo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
