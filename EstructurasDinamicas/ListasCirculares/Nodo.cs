using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDinamicas.ListasCirculares
{
    public class Nodo
    {
        private int Value;
        private Nodo Next;

        public int Values { get { return Value; } set { Value = value; } }
        public Nodo NextValue { get { return Next; } set { Next = value; } }
        
    }
}
