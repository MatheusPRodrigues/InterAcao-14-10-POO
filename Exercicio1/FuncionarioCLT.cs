using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class FuncionarioCLT : Funcionario
    {
        private double Bonus;

        public void SetBonus(double Bonus)
        {
            this.Bonus = Bonus;
        }

        public double GetBonus() 
        {
            return this.Bonus; 
        }

        public override double CalcularSalarioFinal()
        {
            return this.GetSalarioBase() + this.Bonus;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Bonûs: {this.Bonus:C}");
            Console.WriteLine($"Salário total: ${CalcularSalarioFinal():C}");
        }
    }
}
