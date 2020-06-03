using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_io_part1_exercises_pair
{
    public class AskForInput
    {

        //filename location
        public static string fileName;

        public static void FileInput()
        {
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string input = Console.ReadLine().ToLower();

            fileName = input;


        }
        

    }
}
