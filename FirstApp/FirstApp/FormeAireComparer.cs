using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class FormeAireComparer : IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return x.Aire.CompareTo(y.Aire);
        }
    }
}
