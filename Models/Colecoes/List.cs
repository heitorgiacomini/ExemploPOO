using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models.Colecoes
{
    public class List
    {
        public List()
        {
            List<String> estados = new List<String>();
            estados.Add("SP");
            estados.Add("RJ");
            estados.Add("SC");

            Console.WriteLine($"{estados.Count}");

            String[] arrayestados = new string[2] { "MG", "AM" };


            estados.AddRange(arrayestados);

            //estados.ForEach(Console.WriteLine);
            estados.Insert(0, "CEARA");
            estados.ForEach(Console.WriteLine);
        }
    }
}
