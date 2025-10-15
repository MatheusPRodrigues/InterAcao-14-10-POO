using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Carro : Veiculo
    {
        private int NumeroDePortas;

        public void SetNumeroDePortas(int numeroDePortas)
        {
            this.NumeroDePortas = numeroDePortas;
        }

        public int GetNumeroDePortas() 
        { 
            return this.NumeroDePortas; 
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Nº de portas: {this.NumeroDePortas}");
        }
    }
}
