using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public string Cpf;
        public double Altura;

        // Declarar o método construtor é opcional
        public Pessoa()
        {
            
        }

        // Set e Get do Idade
        public void setIdade(int idade)
        {
            // O 'this' aponta para o atributo da instância que está sendo modificada
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        // Get e Set do Nome
        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        // Get e Set do CPF
        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string getCpf()
        {
            return this.Cpf;
        }

        // Get e Set do Altura
        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }
    }
}
