using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Projet_SN_1
{
    class Interface
    {
        public Interface()
        {
            Timer t = new Timer();
            t.Elapsed += T_Elapsed;
            t.Interval = 1000;
            t.Start();
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Toto");
        }
    }
}
