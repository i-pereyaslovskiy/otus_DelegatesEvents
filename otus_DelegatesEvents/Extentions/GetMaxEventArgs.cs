using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_DelegatesEvents.Extentions
{
    internal class GetMaxEventArgs: EventArgs
    {
        private readonly string _getMaxMessage;
        public GetMaxEventArgs(string GetMaxMessage)
        {
            _getMaxMessage = GetMaxMessage; 
        }

        public string MaxMessage { get { return _getMaxMessage; } }
    }
}
