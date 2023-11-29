using System;
using System.IO;

namespace _220Conjuntos {
    internal class Program {
        private static void Main(string[] args) {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            string[] allDirectories = currentDirectory.Split('/');
            string path = "";
            foreach (string directory in allDirectories) {
                path += directory;
                path += "/";
                if (directory == "220Conjuntos") {
                    path += "220Conjuntos/";
                    break;
                }
            }
            path += "Logs.txt";

            SortedSet<string> names = new SortedSet<string>();
            using (StreamReader sr = new StreamReader(path)) {
                while (!sr.EndOfStream) {
                    string name = sr.ReadLine().Split(' ')[0];
                    names.Add(name);
                }
            }

            foreach (string name in names) {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nTotal Count: " + names.Count);
        }
    }
}
