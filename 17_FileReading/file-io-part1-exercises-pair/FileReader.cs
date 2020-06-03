using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace file_io_part1_exercises_pair
{
    class FileReader
    {
        
        public static string TextReader()
        {
            int sentenceCount = 0;
            int wordCount;
 
            string line;
            List<string> allWords = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(AskForInput.fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] words = line.Split(" "); //for the line breaks
                        allWords.AddRange(words);

                        if (line.Contains(".") || line.Contains("?") || line.Contains("!"))
                        {
                            sentenceCount++;
                        }
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file");
            }
            wordCount = allWords.Count;
            string finalWordCount = $"Word Count: {wordCount}";
            string finalSentenceCount = $"Sentence Count: {sentenceCount}";
            return finalWordCount;
            return finalSentenceCount;
            //Console.WriteLine(finalWordCount);
            //Console.WriteLine(finalSentenceCount);
        }
    }
}
