using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Objects
    {
        private static Position block=new Position();

        internal static Position Block
        {
            get { return Objects.block; }
            set { Objects.block = value; }
        }
    }
}
