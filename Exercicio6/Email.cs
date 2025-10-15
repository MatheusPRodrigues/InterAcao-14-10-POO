using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class Email : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando um E-Mail..."); ;
        }
    }
}
