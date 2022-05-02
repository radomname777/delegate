using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Run
    {
        public void runFunc(Func funcDell, string str)
        {
            funcDell(str);
        }
    }
}