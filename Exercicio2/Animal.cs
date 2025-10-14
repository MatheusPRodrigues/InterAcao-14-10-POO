using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public abstract class Animal
    {
        private string Nome;
        private int Idade;

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Grunhindoo!!!");
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Idade: {this.Idade}"; 
        }
    }
}
