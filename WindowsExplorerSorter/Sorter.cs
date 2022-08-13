using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsExplorerSorter {
    public class Sorter {
        List<string> Files;
        List<string> Extensions = new();

        public Sorter(string path) {
            Files = Directory.GetFiles(path).ToList();
            Extensions = GetFileExtensions(path);
            CreateFolders(Extensions, path);
            MoveFiles(path);
        }

        public List<string> GetFileExtensions(string path) {
            List<string> extensions = new();

            foreach (string file in Files) {
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
            Files.ForEach(x => Directory.Move(x, $"{path}\\{Path.GetExtension(x)[1..]}\\{Path.GetFileName(x)}"));
        }
    }
}
