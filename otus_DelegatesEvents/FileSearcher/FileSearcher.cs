using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_DelegatesEvents.FileSearcher
{
    internal class FileSearcher
    {
        const string FileDir = "../../../FilesStorage";


        public event EventHandler<FileArgs>? FileFound;
        public event EventHandler? SearchStopped;
        public bool IsStopSearching;

        public void Searching() {


            foreach (var file in Directory.EnumerateFiles(FileDir, "*.*"))
            {
                if (IsStopSearching)
                {
                    OnSearchStopped();
                    break;
                }
                OnFileFound(Path.GetFileName(file));
            }
        }

        private void OnFileFound(string fileName)
        {
            FileArgs _fileArgs = new FileArgs(fileName);
            FileFound!(this, _fileArgs);
        }

        private void OnSearchStopped()
        {
            SearchStopped(this, EventArgs.Empty);
        }

    }
}
