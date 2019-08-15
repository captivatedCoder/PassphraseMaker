using System.Collections.Generic;
using System.IO;

namespace PassphraseMaker
{
    public class DicewareFileReader
    {
        public List<DicewareFileData> FileData = new List<DicewareFileData>();
        private string FilePath { get; set; }

        public DicewareFileReader(string filePath)
        {
            FilePath = filePath;
        }

        public void WordList()
        {
            foreach (var line in File.ReadLines(FilePath))
            {
                var fileData = new DicewareFileData();
                var tmpLine = line.Split('\t');

                fileData.IdNumber = tmpLine[0];
                fileData.Word = tmpLine[1];

                FileData.Add(fileData);
            }
        }
    }
}
