using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Moto : Veiculo
    {
        private bool Bau;

        public void SetBau(bool bau)
        {
            this.Bau = bau; 
        }

        public bool GetBau()
        {
            return this.Bau;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            if (this.Bau)
                Console.WriteLine("Vem com baú");
            else
                Console.WriteLine("Não vem com baú");
        }
    }
}
