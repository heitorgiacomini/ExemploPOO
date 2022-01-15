using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models.Colecoes
{
    public class QueueFila
    {
        public QueueFila()
        {
            Queue<String> fila = new Queue<String>();
            fila.Enqueue("Leonardo");
            fila.Enqueue("Paulo");
            fila.Enqueue("Gustavo");

            String pessoa = fila.Peek(); //retorna primeira pessoa
            String pessoaatendida = fila.Dequeue(); //retorna primeira pessoa e tira da fila

        }
    }
}
