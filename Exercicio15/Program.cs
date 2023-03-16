namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

            temperaturaFahrenheit = ((temperaturaCelsius * 5) / 9) + 32;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: ${temperaturaFahrenheit}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}