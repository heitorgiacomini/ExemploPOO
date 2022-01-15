using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ClassGenericaA
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public ClassGenericaA LoopclassA = new ClassGenericaA();
    }
}
