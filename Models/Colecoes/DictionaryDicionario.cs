using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models.Colecoes
{
    public class DictionaryDicionario
    {
        public DictionaryDicionario()
        {
            Dictionary<String, String> estados = new Dictionary<String, String>();
            estados.Add("SP","Sao Paulo");
            estados.Add("MG","Minas Gerais");
            estados.Add("BA","Bahia"); 

            foreach (KeyValuePair<String, String> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }
            Console.WriteLine(estados["SP"]);
            estados["SP"] = "Paulo";
            Console.WriteLine(estados["SP"]);
            estados.Remove("MG");

            if(estados.TryGetValue("BA",out String estadoencontrado))
            {
                Console.WriteLine(estadoencontrado);
            }

        }
    }
}
