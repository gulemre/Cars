using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Focus:Car
    {
        public override Car CarCreation()
        {
            return new Focus();
        }
    }
}
