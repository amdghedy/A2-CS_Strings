using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_CS_Strings
{
    class Program
    {

        static void Main(string[] args)
        {
            //T1_ReplaceString();
            //T2_StringUpper();
            //T3_StringExtractText();
            //T4_StringSearch();
            //T5_StringCount();
            //T6_StringReverse();
            //T7_StringTotal();
            //T8_StringSearch();
            //T9_StringCheck();
            //T10_StringMax();
        }

        //Write a C# program to replace the following words with the given ones in the following sentence.
        //Sentence: “Hello Sameh, Welcome to Structural BIM Track.This is Round 1.”
        //Replace “Sameh” with your name.
        //Replace “Structural BIM Track” with “BIM Application Development Track”.
        //Replace “Round 1” with your round number.        

        static void T1_ReplaceString()
        {

            string txt = "Hello Sameh, Welcome to Structural BIM Track. This is Round 1.";

            Console.WriteLine("Please Enter Your Name: ");
            string personName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Track Discription witch is (BIM Application Development Track)");
            string roundName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Track Number: ");
            int roundNumber = int.Parse(Console.ReadLine());


            // Replace "Sameh" with the new name
            txt = txt.Replace("Sameh", personName)

            // Replace "Structural BIM Track" with the new track
                     .Replace("Structural BIM Track", roundName)

            // Replace "Round 1" with the round number
                     .Replace("Round 1", "Round " + roundNumber);

            Console.WriteLine(txt);


        }

        // Write a C# program to read a sentence from the user and replace lowercase characters with uppercase ones.
        //For Example:
        //Input Sentence: “Hello World”
        //Expected Output: “HELLO WORLD”        

        static void T2_StringUpper()
        {
            Console.WriteLine("Please Enter Any sentence to make all litters Uppercase : ");

            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine("\n" + name);
        }

        //Write a C# program to extract a substring from a given string.
        //Note: Don’t use Substring() function.
        //Note: The index for a user starts from 1, while for a developer, starts from 0.
        //For Example:
        //Input string: “Hello World”
        //Input Index to Start Extraction from: 3
        //Input The Length of Substring: 6
        //Expected Output: “llo Wo”.   

         static void T3_StringExtractText()
        {
            Console.WriteLine("Please Enter Any sentence to substring it : ");
            string txt = Console.ReadLine();

            Console.WriteLine("Please Enter the Index to Start Extraction from : ");
            int startIndx = int.Parse(Console.ReadLine());
            //Deffinsive coding to make sure nubers above zero.
            while (!int.TryParse(Console.ReadLine(), out startIndx) || startIndx < 1 || startIndx > txt.Length)
            {
                Console.WriteLine("Invalid input. Please enter a valid index.");
            }

            Console.WriteLine("Please Enter the Length of substring : ");
            int subLen = int.Parse(Console.ReadLine());
            //Deffinsive coding to make sure nubers above zero and below string length.
            while (!int.TryParse(Console.ReadLine(), out subLen) || subLen < 1 || startIndx + subLen - 1 > txt.Length)
            {
                Console.WriteLine("Invalid input. Please enter a valid length.");
            }

            string extTxt = "";

            for (int i = startIndx - 1; i < startIndx - 1 + subLen; i++)
            {
                extTxt += txt[i];
            }

            Console.WriteLine("The extracted substring is:" + extTxt);
        }

        //Write a C# program to search the index of the first occurrence of a given character within a sentence.
        //If the character doesn’t exist in the sentence, print a message.
        //Note: The index for a user starts from 1, while for a developer, starts from 0.
        //Note: Ignore the case sensitivity for character search.
        //For Example:
        //Input Sentence: “Hello World”
        //Input Character: ‘o’
        //Expected Output: 5
        //Input Character: ‘O’
        //Expected Output: 5
        //Input Character: ‘z’
        //Expected Output: “The character ‘z’ doesn’t exist”        
        //</summary>

        static void T4_StringSearch()
        {

            Console.WriteLine("Please Enter Any sentence to search in : ");
            string txt = Console.ReadLine();
            string txt1 = txt.ToLower();
            Console.WriteLine("Please Enter the character that you want check: ");
            string txtchar = Console.ReadLine();
            string txt2 = txtchar.ToLower();
            if (txt1.Contains(txt2))
            {
                Console.WriteLine("Your Character locate in : " + txt1.IndexOf(txt2));
            }
            else
                Console.WriteLine("The Litter Not Found in the sentence : ");

        }

        /// Write a C# program to count the total number of vowels in a string.
        /// </summary>

        static void T5_StringCount()
        {
            Console.WriteLine("Kindly Enter any text to check how many vowels in it ");
            string txt = Console.ReadLine();
            int vowlNum = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                char x = char.ToLower(txt[i]);
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    vowlNum++;
                }

            }
            Console.WriteLine("The number of vowels is : " + vowlNum);
        }

        //Write a C# program to print individual characters of a string in reverse order and separate them with spaces.
        //Note: Put only one space between each character.
        //Note: Eliminate spaces in the first or the last position of the string.
        //For Example:
        //Input: “Hello World”
        //Expected Output: “d l r o W o l l e H”        

        static void T6_StringReverse()

        {
            Console.WriteLine("Kindly enter a sentence to reverse it");
            string txt = Console.ReadLine();
            char[] arr = txt.ToCharArray();
            Array.Reverse(arr);

            // Print reversed string with spaces
            foreach (char x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        //Write a C# program to count the total number of words in a string.
        //For Example:
        //Input: “Welcome to BIM Application Development Track”
        //Expected Output: 6        

        static void T7_StringTotal()
        {
            Console.WriteLine("Please enter a sentence to count the total number of words: ");
            string txt = Console.ReadLine();
            string[] arr = txt.Split(' ');
            if (string.IsNullOrWhiteSpace(txt) || string.IsNullOrEmpty(txt))
            {
                Console.WriteLine("Please enter a valid sentence.");
            }
            else

            Console.WriteLine("The total number of Words is :" + arr.Length);

        }


        //Write a C# program to check whether a given word is present in a given sentence.
        //For Example:
        //Input Sentence: “This is Task 8 in Strings Tasks”
        //Input Word: “is”
        //Expected Output: “The word ‘is’ exists in the sentence”.
        //Input Word: “Assignment”
        //Expected Output: “The word ‘Assignment’ doesn’t exist in the sentence”.       

        static void T8_StringSearch()
        {
            Console.WriteLine("Please input a sentence to verify the presence of a specific word:");
            string txt = Console.ReadLine();

            Console.WriteLine("Kindly input the word you wish to verify within the provided sentence:");
            string txt1 = Console.ReadLine();

            int count = 0;
            string[] x = txt.Split(' ');

            foreach (string XX in x)
            {
                if (XX.ToLower() == txt1.ToLower())
                {
                    count++;
                }
            }

            Console.WriteLine("The word '" + txt1 + "' is found " + count + " times in the sentence.");
        }


        //Write a C# program to check if the first character of each word in a sentence is uppercase or not.
        //If not, print the word that doesn’t follow the condition.
        //For Example:
        //Input Sentence: “My Name Is Sameh”
        //Expected Output: “All Words are Following The Condition”.
        //Input Sentence: “My name is Sameh”
        //Expected Output: “There are 2 Words Not Following The Condition:”
        //“1- name”
        //“2- is”       

        static void T9_StringCheck()
        {
            Console.WriteLine("Enter a sentence:");
            string txt = Console.ReadLine();

            string[] arr = txt.Split(' ');

            int numUpper = 0;
            int numLower = 0;

            Console.WriteLine("Words that start with an uppercase letter:");
            foreach (string xx in arr)
            {
                if (char.IsUpper(xx[0]))
                {
                    Console.WriteLine(xx);
                    numUpper++;
                }
                else
                {
                    numLower++;
                }
            }



            Console.WriteLine("Words that do not start with an uppercase letter:");
            foreach (string xx in arr)
            {
                if (!char.IsUpper(xx[0]))
                {
                    Console.WriteLine(xx);
                }
            }

            Console.WriteLine("Total number of words that do not start with an uppercase letter: {0}", numLower);

        }
   
        //Write a C# program to find the maximum occurring character in a string.
        //Note: If there’s more than one character that has the maximum occurring value, get the first one only.
        //Note: Ignore the case sensitivity.
        //For Example:
        //Input: “HELLO World”
        //Expected Output: “The Highest frequency of character 'L' appears 3 times”.        

        static void T10_StringMax()

        {

            Console.WriteLine("Please Enter Any sentence to find maximum occurring value in it: ");
            string txt = Console.ReadLine();

            string txt1 = txt.ToLower();

            char maxChar = '\0';
            int maxCount = 0;
            int[] charCount = new int[26];

            foreach (char x in txt1)
            {
                if (char.IsLetter(x))

                    charCount[x - 'a']++;
            }

            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] > maxCount)
                {
                    maxChar = (char)(i + 'a');
                    maxCount = charCount[i];
                }
            }

            int finalMaxCount = 0;
            foreach (char x in txt1)
            {
                if (char.ToLower(x) == maxChar)
                    finalMaxCount++;
            }

            Console.WriteLine($"The highest frequency of character '{maxChar}' appears {finalMaxCount} times.");
        }
    }
}
