using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendeDePessoas
{
    internal class Endereco
    {
        public string Logradouro;
        public int Numero;
        public string Bairro = String.Empty;
        public string Cep;
        public string? Complemento;
        public string Cidade;
        public string Estado;
        public string Pais = string.Empty;

        public Endereco(string logradouro, 
            int numero,
            string bairro,
            string cep,
            string? complemento,
            string cidade,
            string estado,
            string pais)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Endereço: {this.Logradouro}, {this.Numero}");
            Console.WriteLine($"Bairro: {this.Bairro}");
            Console.WriteLine($"CEP: {this.Cep}");

            if (this.Complemento != null)
                Console.WriteLine($"Complemento: {this.Complemento}");
            
            Console.WriteLine($"Cidade: {this.Cidade}");
            Console.WriteLine($"Estado: {this.Estado}");
            Console.WriteLine($"País: {this.Pais}");
        }
    }
}
