using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models.Colecoes
{
    public class StackPilha
    {
        public StackPilha()
        {
            Stack<String> pilha = new Stack<String>();
            
            pilha.Push(".NET");
            pilha.Push("DDD");
            pilha.Push("Codigo Limpo");

            String livro = pilha.Peek(); //retorna ultimo livro
            String livrolido = pilha.Pop(); //retorna ultimo livro e Retira da pilha

        }




    }
}
