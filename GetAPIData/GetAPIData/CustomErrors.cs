using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAPIData
{
    class CustomErrors : Exception
    {
        public CustomErrors(string msg) : base(msg)
        {

        }
    }
}
