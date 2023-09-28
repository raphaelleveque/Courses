namespace Files;

class Program {
    static void Main(string[] args) {
        string directory = "/Users/raphaelleveque/Desktop/cs/courses/udemy/C#/Section13/";
        string filename = "itens.csv";
        string path = directory + filename;

        string newDirectory = directory + "out/";
        string newFilePath = directory + "out/summary.csv";
        if (!Directory.Exists(newDirectory)) {
            Directory.CreateDirectory(newDirectory);
        }

        using (StreamReader reader = new StreamReader(path)) {
            using (StreamWriter writer = new StreamWriter(newFilePath)) {
                reader.ReadLine();
                string? line;
                while ((line = reader.ReadLine()) != null) {
                    string[] csvfile = line.Split(',');
                    writer.Write(csvfile[0] + ",");
                    double valorFinal = double.Parse(csvfile[1]) * int.Parse(csvfile[2]);
                    writer.Write(valorFinal.ToString("F2") + "\n");

                }
            }
        }
    }
}

