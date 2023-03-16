namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário base do vendedor: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual da comissão sobre as vendas (em %): ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double comissao = (percentualComissao / 100) * totalVendas;

            double salarioTotal = salarioBase + comissao;

            Console.WriteLine($"O salário total do vendedor é: {salarioTotal}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}