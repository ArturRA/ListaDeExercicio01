namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometragemInicial, quilometragemFinal, distanciaPercorrida, consumoCombustivel;

            Console.WriteLine("Digite a quilometragem inicial: ");
            quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustível (em litros): ");
            consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            distanciaPercorrida = quilometragemFinal - quilometragemInicial;

            double consumoPorKm = consumoCombustivel / distanciaPercorrida;

            Console.WriteLine($"O consumo de combustível por Km é: {consumoPorKm}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}