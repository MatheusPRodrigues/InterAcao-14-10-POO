using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class PushNotification : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando uma PushNotification..."); ;
        }
    }
}
