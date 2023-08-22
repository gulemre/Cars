using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class F150:Car
    {
        public override Car CarCreation()
        {
            return new F150();
        }
    }
}
