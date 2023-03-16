namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            int fib1 = 0, fib2 = 1;

            Console.Write(fib1 + " " + fib2 + " ");

            while (fib2 < numeroDigitado)
            {
                int fib3 = fib1 + fib2;
                Console.Write(fib3 + " ");
                fib1 = fib2;
                fib2 = fib3;
            }

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}