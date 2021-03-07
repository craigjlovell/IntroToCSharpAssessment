/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = LoadWords("words.txt");
            SortWords(words);
            SaveWords("output.txt", words);

        }

        public static List<string> LoadWords(string filename)
        {

            List<string> words = new List<string>();
            string read;
            using (StreamReader sr = File.OpenText(filename))
            {
                // reads the first line of words in txt file which states the number of words
                var numberOfWords = sr.ReadLine();
                
                // read the rest of the words and put in the list
                while((read = sr.ReadLine()) !=null)
                {
                    words.Add(read);
                }
            }

            return words;
        }
        public static void SortWords(List<string> words)
        {
            words.Sort();
            
        }
        public static void SaveWords(string filename, List<string> words)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                for(int i = 0; i < words.Count; i++)
                {
                    sw.WriteLine(words[i]);
                }
                
            }
        }
    }
}
