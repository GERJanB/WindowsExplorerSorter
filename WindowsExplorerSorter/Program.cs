using System;

namespace WindowsExplorerSorter {
    class Program {
        static void Main(string[] args) {
            Sorter sorter = new();
            var s = sorter.GetFileExtensions();
            s.ForEach(x => Console.WriteLine(x));
        }
    }
}
