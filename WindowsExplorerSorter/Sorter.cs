using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsExplorerSorter {
    public class Sorter {
        public Sorter(string path) { 
            CreateFolders(GetFileExtensions(path), path);
            MoveFiles(path);
        }

        public List<string> GetFileExtensions(string path) {
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

        public void CreateFolders(List<string> extensions, string path) {
            extensions.ForEach(x => Directory.CreateDirectory($"{path}\\{x[1..]}"));
        }

        public void MoveFiles(string path) {
            List<string> files = Directory.GetFiles(path).ToList();

            files.ForEach(x => Directory.Move(x, $"{path}\\{Path.GetExtension(x)[1..]}\\{Path.GetFileName(x)}"));
        }
    }
}
