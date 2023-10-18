using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_gyakorlas
{
    internal class Negyzet
    {
        int aOldal;

        public Negyzet(int aOldal)
        {
            this.aOldal = aOldal;
        }

        public int AOldal { get => aOldal; }
    }
}
