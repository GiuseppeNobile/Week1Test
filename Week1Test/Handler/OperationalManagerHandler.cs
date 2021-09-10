﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    class OperationalManagerHandler : AbstractHandler
    {
        public override string ApprovaSpesa(double importo)
        {
            if (importo > 401 && importo <= 1000)
            {
                Console.WriteLine("spesa approvata");
                return "APPROVATA";
            }
            else if (importo > 2500)
            {
                Console.WriteLine("spesa respinta");
                return "RESPINTA";
            }
            else
            {
                Console.WriteLine("spesa respinta");
                return "RESPINTA";
            }
        }
    }
}
