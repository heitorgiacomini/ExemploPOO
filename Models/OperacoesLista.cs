namespace ExemploPOO.Models
{
    public class OperacoesLista
    {
        public OperacoesLista()
        {
            List<String> estados = new List<String>();
            estados.Add("SP");
            estados.Add("RJ");
            estados.Add("SC");

            Console.WriteLine($"{estados.Count}");

            String[] arrayestados = new string[2] { "MG", "AM" };


            estados.AddRange(arrayestados);

            estados.ForEach(Console.WriteLine);
        }

    }
}
