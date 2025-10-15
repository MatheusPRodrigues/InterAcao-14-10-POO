using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Caminhao : Veiculo
    {
        private double CapacidadeDeCarga;

        public void setCapacidadeDeCarga(double capacidadeDeCarga)
        {
            this.CapacidadeDeCarga = capacidadeDeCarga;
        }

        public double getCapacidadeDeCarga()
        {
            return this.CapacidadeDeCarga;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Capacidade de carga {this.CapacidadeDeCarga:F2}kg");
        }
    }
}
