using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsExplorerSorter {
    public class Sorter {
        string path;
        public Sorter(string path) { 
            this.path = path;
            CreateFolders(GetFileExtensions());
        }

        public List<string> GetFileExtensions() {
            List<string> extensions = new();
            List<string> files = Directory.GetFiles(path).ToList();

            foreach (string file in files) {
                var s = Path.GetExtension(file);
                if (!extensions.Contains(s)) {
                    extensions.Add(s);
                }
            }

            return extensions;
        }

        public void CreateFolders(List<string> extensions) {
            extensions.ForEach(x => Directory.CreateDirectory($"{path}\\{x[1..]}"));
        }
    }
}
