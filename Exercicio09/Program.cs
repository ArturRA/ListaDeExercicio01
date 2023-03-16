namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, nota4;

            Console.WriteLine("Digite as quatro notas do aluno:");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            nota2 = Convert.ToDecimal(Console.ReadLine());
            nota3 = Convert.ToDecimal(Console.ReadLine());
            nota4 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica}");

            Console.Write("\nDigite qualquer tecla para continuar o programa.");
            Console.ReadLine();
        }
    }
}