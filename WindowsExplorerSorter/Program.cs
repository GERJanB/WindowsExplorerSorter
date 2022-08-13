using System;

namespace WindowsExplorerSorter {
    class Program {
        static void Main(string[] args) {
            string path = "C:\\Users\\janbu\\Desktop\\SorterTest";

            Sorter sorter = new(path);
            var s = sorter.GetFileExtensions();
            s.ForEach(x => Console.WriteLine(x));
        }
}
}
