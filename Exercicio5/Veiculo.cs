using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public abstract class Veiculo
    {
        private string Marca;
        private string Modelo;
        private int Ano;

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public string GetMarca()
        {
            return this.Marca;
        }

        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public string GetModelo()
        {
            return this.Modelo;
        }

        public void SetAno(int ano)
        {
            this.Ano = ano;
        }

        public int GetAno()
        {
            return this.Ano;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano: {this.Ano}");
        }
    }
}
