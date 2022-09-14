using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Threading;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;
using System.Collections;

namespace writingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letterCount = 0;
            int letter;

            if (File.Exists("letters.txt"))
            {
                This activity creates a dictionary list with 5 keys:
                A, E, I, O, U
                For each key stored we will store the number of times this letter appears in the file.
int ASCIIletter;
                char letter;
                //create dictionary list with all the vowels
                Dictionary<Char, int> vowels = new Dictionary<char, int>();
                vowels.Add('A', 0);
                vowels.Add('E', 0);
                vowels.Add('I', 0);
                vowels.Add('O', 0);
                vowels.Add('U', 0);
                if (File.Exists("letters.txt"))
                {
                    StreamReader inputFile = new StreamReader("letters.txt");
                    //read the first character
                    ASCIIletter = inputFile.Read();
                Teacher: Ariane Warnant Email: ariane.warnant @tafensw.edu.au Phone: 9472 1973 Hornsby Campus
                C:\ariane\TAFE\classes\programming\C sharp FT 2020\11.Files\Reading and writing to files.docx
                Page 7 of 8
                Created: 3 / 03 / 2020
                Date last reviewed: 7 / 03 / 2020
                //loop through each letter
while (ASCIIletter != -1)
                    {
                        //convert the ASCII value to a character
                        letter = (char)ASCIIletter;
                        //check if the chracter is a vowel
                        if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                        {
                            vowels[letter]++;
                        }
                        ASCIIletter = inputFile.Read();
                    }
                    //loop through the dictionary list and display each vowel and count
                    foreach (KeyValuePair<char, int> kvp in vowels)
                    {
                        Console.WriteLine(kvp.Key + " appeared " + kvp.Value);
                    }
                }
        }
    }
}
