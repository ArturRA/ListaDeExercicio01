namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDecimal(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é menor que C.");
            }

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}