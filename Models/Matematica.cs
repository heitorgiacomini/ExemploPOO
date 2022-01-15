namespace ExemploPOO.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;
            new Calculadora().EventoCalculadora += EventHandler;
        }

        public void Somar (){
           new Calculadora().Somar(X, Y);  
        }

        public void EventHandler() {
            Console.WriteLine("Executando Metodo");
        }
    }
}
