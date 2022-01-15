namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, string sobrenome) : base(nome, sobrenome)
        {

        }
        public double salario { get; set; } 

        public override void Apresentar()
        {
            System.Console.WriteLine("SOU PROFESSOR " + nome + sobrenome);
        }
         

    }
}