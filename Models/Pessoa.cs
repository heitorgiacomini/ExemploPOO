using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;

        // public Pessoa()// exemplo de construtor da classe Pessoa SEM parâmetro;
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome)// exemplo de construtor da classe Pessoa COM parâmetro;
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa!");
        }

        public virtual void Apresentar()
        {
            System.Console.WriteLine("SOU PESSOA "+ nome + sobrenome);
        }
    }
}