using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendeDePessoas
{
    internal class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;
        public string Sexo;
        public double Altura;
        public Endereco Endereco;

        public Pessoa()
        {
            
        }

     
        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }


        public void setSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.Sobrenome;
        }


        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }


        public void setSexo(string sexo)
        {
            this.Sexo = sexo;
        }

        public string getSexo()
        {
            return this.Sexo;
        }


        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }


        public void setEndereco(Endereco endereco)
        {
            this.Endereco = endereco;
        }

        public Endereco GetEndereco()
        {
            return this.Endereco;
        }

        //public string ExibirInformacoes()
        //{
        //    // Usar o método gasta mais processamento da  máquina
        //    //return $"Nome completo: {getNome()} {getSobrenome()}\n" +
        //    //    $"Idade: {getIdade()} anos\n" +
        //    //    $"Sexo: {getSexo()}\n" +
        //    //    $"Altura: {getAltura()}M";

        //    return $"Nome completo: {this.Nome} {this.Sobrenome}\n" +
        //        $"Idade: {this.Idade} anos\n" +
        //        $"Sexo: {this.Sexo}\n" +
        //        $"Altura: {this.Altura}m\n" +
        //        $"Endereço: {this.Endereco.ToString()}";
        //}

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome completo: {this.Nome} {this.Sobrenome}");
            Console.WriteLine($"Idade: {this.Idade} anos");
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Altura: {this.Altura}m");
            this.Endereco.ExibirInformacoes();
        }
    }
}
