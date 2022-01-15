namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome, string sobrenome) :base(nome, sobrenome)
        {
        }
        public override void Apresentar()
        {
            Console.WriteLine("SOU DIRETOR" + nome + sobrenome);
        }
    }
}