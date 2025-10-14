using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class FuncionarioPJ : Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;

        public void SetHorasTrabalhadas(int horasTrabalhadas)
        {
            this.HorasTrabalhadas = horasTrabalhadas;
        }

        public int GetHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }

        public void SetValorHora(double valorHora)
        {
            this.ValorHora = valorHora;
        }

        public double GetValorHora()
        {
            return this.ValorHora;
        }

        public override double CalcularSalarioFinal()
        {
            return this.HorasTrabalhadas * this.ValorHora;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Horas trabalhadas: {this.HorasTrabalhadas}h");
            Console.WriteLine($"Valor hora: {this.ValorHora:C}");
            Console.WriteLine($"Salário total {this.CalcularSalarioFinal():C}");
        }
    }
}
