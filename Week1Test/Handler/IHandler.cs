using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public interface IHandler
    {
        IHandler Successivo(IHandler handler);
        string Gestisci(string request);
        
    }
}
