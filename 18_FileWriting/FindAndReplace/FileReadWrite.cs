using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FindAndReplace
{
    public class FileReadWrite
    {
        public static void TextReader()
        {
            //int sentenceCount = 0;
            //int wordCount;

            //string line;
            //List<string> allWords = new List<string>();
            try
            {
                using (StreamReader input = new StreamReader(AskForInput.combinedInputDirectoryAndFile))
                using (StreamWriter output = new StreamWriter(AskForInput.fullPath))
                {
                    while (!input.EndOfStream)
                    {
                        string original = input.ReadLine();
                        output.WriteLine(original.Replace(AskForInput.searchPhrase, AskForInput.replacePhrase));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file");
            }

            
        }

        //using (StreamReader sr = new StreamReader(AskForInput.fileName))
        //{
        //    while (!sr.EndOfStream)
        //    {
        //        line = sr.ReadLine();
        //        string[] words = line.Split(" "); //for the line breaks
        //        allWords.AddRange(words);

        //        if (line.Contains(".") || line.Contains("?") || line.Contains("!"))
        //        {
        //            sentenceCount++;
        //        }
        //    }
        //}

        //wordCount = allWords.Count;
        //    string finalWordCount = $"Word Count: {wordCount}";
        //string finalSentenceCount = $"Sentence Count: {sentenceCount}";
        ////return finalWordCount;
        ////return finalSentenceCount;
        //Console.WriteLine(finalWordCount);
        //    Console.WriteLine(finalSentenceCount);




    }
}
