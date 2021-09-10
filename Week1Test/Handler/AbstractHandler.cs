using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _prossimoHandler;

        public virtual string ApprovaSpesa(double importo)
        {
            return "spesa da controllare";
        }

        public string Gestisci(string request)
        {
            if(_prossimoHandler != null)
            {
                return _prossimoHandler.Gestisci(request);
            }
            return null;
        }

        public IHandler Successivo(IHandler handler)
        {
            _prossimoHandler = handler;
            return _prossimoHandler;
        }
    }
}
