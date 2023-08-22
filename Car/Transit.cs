using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Transit : Car
    {
        
        public override Car CarCreation()
        {
            return new Transit();
        }

     

    }
}
