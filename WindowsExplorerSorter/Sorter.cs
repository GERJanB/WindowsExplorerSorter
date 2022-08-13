using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsExplorerSorter {
    public class Sorter {
        private readonly string path = "C:\\Users\\janbu\\Desktop\\SorterTest";

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
    }
}
