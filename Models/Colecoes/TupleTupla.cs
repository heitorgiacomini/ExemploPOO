using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models.Colecoes
{
    public class TupleTupla
    {
        public TupleTupla()
        {
            Tuple<int, string, string> person =
                        new Tuple<int, string, string>(1, "Steve", "Jobs");
        }
    }
}
