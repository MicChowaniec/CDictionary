using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     public class KeyComparer : IComparer<ComposedKey>
    {
        public int Compare(ComposedKey x, ComposedKey y)
        {
            int tmp = String.Compare(x.KeyA, y.KeyA);

            if (tmp == 0)
                return String.Compare(x.KeyB, y.KeyB);

            return tmp;
        }
    }

