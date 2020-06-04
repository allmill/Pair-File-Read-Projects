using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FindAndReplace
{
    
        public class AskForInput
        {

        //filename location
        //Inputs for phrase or Word
        public static string searchPhrase;
        public static string replacePhrase;

        //file to copy directory AND filename
        public static string sourcePath;
        public static string inputFileName;
        public static string combinedInputDirectoryAndFile;


        //Output
        public static string outputFile;
        public static string finalFile;
        public static string destinationPath;
        public static string fullPath;


        public static void FileInput()
            {
            

                Console.WriteLine("What is the phrase to search for?");
                searchPhrase = Console.ReadLine();

                Console.WriteLine("What is the phrase to replace with?");
                replacePhrase = Console.ReadLine();


                Console.WriteLine("What is the source file path? Do not include file name yet.");
                try
                {
                //Environment.CurrentDirectory = @"C:\Users\Student\workspace\pairs\csharp-week-4-team-4\18_FileWriting";
                        sourcePath = Console.ReadLine();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error: File Not Found");
                }

                Console.WriteLine("What is the name of the file?");
                inputFileName = Console.ReadLine();

                combinedInputDirectoryAndFile = Path.Combine(sourcePath, inputFileName);

                //File.Copy(sourcePath, finalFile);

                Console.WriteLine("Where would you like the new file to be generated? The path only.");
                destinationPath = Console.ReadLine();
                Environment.CurrentDirectory = destinationPath;

                Console.WriteLine("What is the name of the adjusted file?");
                finalFile = Console.ReadLine();
                fullPath = Path.Combine(destinationPath, finalFile);

                if (File.Exists(fullPath))
                {
                Console.WriteLine("File already exists, terminating program");
                Console.ReadLine();
                System.Environment.Exit(1);
                }
                else
                {
                //fullPath = Path.Combine(destinationPath, finalFile);
                }
                

        }


        }




        //public static string searchPhrase;
        //public static string replacePhrase;
        //public static void UserPrompt()
        //{
        //    Console.WriteLine("What is the phrase to search for?");
        //    searchPhrase = Console.ReadLine();

        //    Console.WriteLine("What is the phrase to replace with?");
        //    replacePhrase = Console.ReadLine();

        //    try
        //    {
        //        Console.WriteLine("What is the source file path?");
        //    }
        //    catch (IOE)
        //}



}
