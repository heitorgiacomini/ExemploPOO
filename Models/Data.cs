using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Data
    {
        private int mes;
        private bool mesvalido;

        public int Mes
        {
            get { return mes; }
            set {
                if(0 > value && value  < 12)
                {
                    Mes = value;    
                    mesvalido = true;   
                }
            }
        }

    }
}
