using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoFolha
{
    public class FuncionarioSalario
    {
        public string Nome;
        public double Salario;
        public double Imposto;
       

        public double CalcSalarioLiquido()
        {
            return Salario - (Salario * (Imposto / 100));
        }

        public void CalcNovoSalario(double aumento)
        {
            Salario = Salario + (Salario * aumento / 100);
        }
    }
}
