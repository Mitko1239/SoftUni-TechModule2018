using System.IO;

namespace p05_FolderSize
{
    class P05
    {
        static void Main(string[] args)
        {
            string inputFolder = @"../LabResources/05. Folder Size/TestFolder";
            string outputFile = "folder-size.txt";
            var files = Directory.GetFiles(inputFolder);
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText(outputFile, sum.ToString());
        }
    }
}