using System.Linq;
namespace ExemploPOO.Models.Colecoes
{
    public class LINQ
    {
        public LINQ()
        {

            //int[] arraynumeross = new int[8] {100, 4, 2, 2, 3, 4, 5, 3};

            List<int> arraynumeros = new List<int> {100, 4, 2, 2, 3, 4, 5, 3};
            Console.WriteLine("Minha Lista");
            Console.WriteLine(String.Join(", ",arraynumeros)+ "\n");


            Console.WriteLine("Soma dos Valor");
            Console.WriteLine(arraynumeros.Sum());
            Console.WriteLine("Valores sem se repetir");
            Console.WriteLine(String.Join(", ", arraynumeros.Distinct().ToList()));
            
            Console.WriteLine("\nValor Minimo");
            Console.WriteLine(arraynumeros.Min());
            Console.WriteLine("Valor Medio");
            Console.WriteLine(arraynumeros.Average());
            Console.WriteLine("Valor Maximo");
            Console.WriteLine(arraynumeros.Max()+ "\n");

            //Query Syntax
            var numerospares = 
                from num in arraynumeros
                where num %2 ==0
                orderby num
                select num;

            var numimpares = arraynumeros.Where(x=> x%2 != 0).OrderBy(x=>x).ToList();   
            //Method Syntax
            


            List<int> list = new List<int>();
            list.AddRange(numerospares);
            Console.WriteLine("NUMEROS PARES");
            list.ForEach(Console.WriteLine);
            
            Console.WriteLine("NUMEROS IMPARES");
            numimpares.ForEach(Console.WriteLine);


            Console.WriteLine("\nLista Ordenada");
            arraynumeros.Sort();
            Console.WriteLine(String.Join(", ", arraynumeros));
            Console.WriteLine("Lista Invertida");
            arraynumeros.Reverse();
            Console.WriteLine(String.Join(", ", arraynumeros));



        }
    }
}
