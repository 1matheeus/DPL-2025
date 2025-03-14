using System;
using System.IO;
using System.Security.Cryptography;

namespace arquivohash
{
    internal class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        static void Main(string[] args)
        {
            byte[] salt = new byte[16];
            rngCsp.GetBytes(salt);

            Console.WriteLine("Digite o nome de usuario: ");
            string user = Console.ReadLine();
            var userh = new Rfc2898DeriveBytes(user, salt, 1000);
            Console.WriteLine("Digite sua cidade: ");
            string city = Console.ReadLine();
            var cityh = new Rfc2898DeriveBytes(city, salt, 1000);
            Console.WriteLine("Digite seu ano de Nascimento:");
            string aniver = Console.ReadLine();
            var aniverh = new Rfc2898DeriveBytes(aniver, salt, 1000);

            byte[] hash = userh.GetBytes(20);
            byte[] userhf = new byte[36];

            Array.Copy(salt, 0, userh, 0, 16);
            Array.Copy(hash, 0, userh, 16, 20);

            string userhs = Convert.ToBase64String(userh);
            Console.WriteLine($"\nHash da senha gerado : {userhs}");

            Console.ReadKey();

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Alunos\\Downloads\\DPL-72\\arquivohash\\senhas.txt"))
            {
                writer.WriteLine($"User: {userh}");
                writer.WriteLine($"Cidade: {cityh}");
                writer.WriteLine($"Ano de Nascimento: {aniverh}");
            }


            
        }
    }
}
