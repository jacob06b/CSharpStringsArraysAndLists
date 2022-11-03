using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen
        public static void coordinates()
        {
            double xcoord = 23.36547d;
            double ycoord = 92.45435d;
            double zcoord = 1.4059d;
            double[] location = new double[3];
            location[0] = xcoord;
            location[1] = ycoord;
            location[2] = zcoord;
            Console.WriteLine(String.Join(", ", location));
            
        }
    // 2: Byte Arrays
    // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
    // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 
    public static void byteArray()
        {
            string string1 = "hello";
            string string2 = "你好";
            byte[] byteA = Encoding.ASCII.GetBytes(string1);
            Console.WriteLine(String.Join(", ", byteA));
            byte[] byteB = Encoding.ASCII.GetBytes(string2);
            Console.WriteLine(String.Join(", ", byteB));
        }
        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out
    public static void Temperatures()
        {
            List<double> temps = new List<double>();
            temps.Add(22);
            temps.Add(4);
            temps.Add(18);
            temps.Add(17);
            temps.Add(7);
            temps.Add(9);

            double minTemp = temps[1];
            double maxTemp = 0;
            double tempTotal = 0;


            for (int i = 0; i < temps.Count - 1; i++)
            {
                if (temps[i] > maxTemp)
                {
                    maxTemp = temps[i];
                }
                else if (temps[i] < minTemp)
                {
                    minTemp = temps[i];
                }
                tempTotal += temps[i];
            }
            double averageTemp = tempTotal / temps.Count;
            
            Console.WriteLine(maxTemp);
            Console.WriteLine(minTemp);
            Console.WriteLine(averageTemp);

            temps.Sort();

            Console.WriteLine(String.Join(",", temps));

        }
        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out     

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.
        public static string PigLatin(string input)
        {
            throw new NotImplementedException();
        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
