using System;

namespace WindowsExplorerSorter {
    class Program {
        static void Main(string[] args) {
            string path = args[0];

            Sorter sorter = new(path);
        }
    }
}
