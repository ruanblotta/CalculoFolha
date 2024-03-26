using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioSalario funcionario = new FuncionarioSalario();
            
            Console.WriteLine("Informe o funcinário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o índice de imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome:" + funcionario.Nome);

            double salarioLiquido = funcionario.CalcSalarioLiquido();
            Console.WriteLine("Salário Líquido: " + salarioLiquido);

            Console.WriteLine("Informe o índice de aumento: ");
            double taxaAumento = double.Parse(Console.ReadLine());

            funcionario.CalcNovoSalario(taxaAumento);

            Console.WriteLine("Nome: " + funcionario.Nome);

            salarioLiquido = funcionario.CalcSalarioLiquido();
            Console.WriteLine("Salário Líquido: " + salarioLiquido);
        }
    }
}
