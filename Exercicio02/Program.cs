namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em graus Celsius é: ${temperaturaCelsius}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}