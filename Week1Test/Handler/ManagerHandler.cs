using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public class ManagerHandler : AbstractHandler
    {
        public override string ApprovaSpesa(double importo)
        {
            if (importo <= 400)
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
