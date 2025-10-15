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

        //public Animal(string nome, int idade)
        //{
        //    this.Nome = nome;
        //    this.Idade = idade;
        //}

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        //Correcao do EmitirSom()
        public abstract void EmitirSom();

        //public virtual void EmitirSom()
        //{
        //    Console.WriteLine("Grunhindoo!!!");
        //}

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Idade: {this.Idade}"; 
        }
    }
}
