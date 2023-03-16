namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorAumento = 0.15m;
            decimal impostos = 0.8m;

            decimal salarioAtual, salarioComAumento, salarioFinal;

            Console.Write("Digite o seu salário atual: ");
            salarioAtual = Convert.ToDecimal(Console.ReadLine());

            salarioComAumento = salarioAtual + salarioAtual * valorAumento;

            salarioFinal = salarioComAumento - salarioComAumento * impostos;

            Console.WriteLine($"\nO salário com aumento é: {salarioComAumento}");
            Console.WriteLine($"O salário final é: {salarioFinal}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}