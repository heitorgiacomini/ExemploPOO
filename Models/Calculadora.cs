namespace ExemploPOO.Models
{
    public class Calculadora  
    {
        //Delegate
        public delegate void DelegateCalculadora();
        //Event
        public event DelegateCalculadora EventoCalculadora;
        public event EventHandler Evento;


        public void Somar(int x, int y)
        {
            if(this.EventoCalculadora != null)
            {
                System.Console.WriteLine("Adicao x+y: "+(x + y));
                this.EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum Escrito ");
            }
        } 

        public static int Subtrair(int x, int y)
        {
            return x-y;
        }
        public int Dividir(int num1, int num2)
        {
            return num1/num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1*num2;
        }

    }
}