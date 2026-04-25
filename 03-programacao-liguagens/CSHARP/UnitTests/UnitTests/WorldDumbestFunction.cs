using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class WorldDumbestFunction
    {
        public string ReturnSuccessIfZero (int num) 
        {
            if (num == 0) return "Success";
            else
            {
                return "Fail";
            }
        }
    }
}
