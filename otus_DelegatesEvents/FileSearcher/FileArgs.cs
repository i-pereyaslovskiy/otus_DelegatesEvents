using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_DelegatesEvents.FileSearcher
{
    internal class FileArgs:EventArgs
    {
        public string FileName { get; } = null!;

        public FileArgs(string fileName)
        {
            FileName = fileName;
        }

    }
}
