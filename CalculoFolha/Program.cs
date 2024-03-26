using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, imposto;

            Console.WriteLine("Informe o funcinário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o índice de imposto: ");
            imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome:" + nome);

            double salarioLiquido = CalcSalarioLiquido(salario, imposto);
            Console.WriteLine("Salário Líquido: " + salarioLiquido);

            Console.WriteLine("Informe o índice de aumento: ");
            double taxaAumento = double.Parse(Console.ReadLine());

            double salarioNovo = CalcAumento(salario, taxaAumento);

            Console.WriteLine("Nome: " + nome);

            salarioLiquido = CalcSalarioLiquido(salarioNovo, imposto);
            Console.WriteLine("Salário Líquido: " + salarioLiquido);
        }

        public static double CalcSalarioLiquido (double salario, double imposto)
        {
            double salarioLiquido = salario - (salario * (imposto / 100));

            return salarioLiquido;
        }

        public static double CalcAumento(double salario, double aumento)
        {
            double novoSalario = salario + (salario * aumento / 100);

            return novoSalario;
        }
    }
}
