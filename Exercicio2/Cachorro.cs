using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Cachorro : Animal
    {
        // Quando há um construtor declarado na classe abstrata a classe filha PRECISA também ter o construtor
        //public Cachorro(string nome, int idade) : base(nome, idade)
        //{
        //}

        public override void EmitirSom()
        {
            Console.WriteLine("Au au au");
        }
    }
}
