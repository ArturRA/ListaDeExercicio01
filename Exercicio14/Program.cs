namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasDeVida;

            Console.Write("Por favor, informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nAgora informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            diasDeVida = idade * 365;

            Console.WriteLine($"{nome}, você já viveu {diasDeVida} dias");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}