using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean agree = true;
            while (agree)
            {

                Console.WriteLine("Welcome to the Pig Latin Translator!"); //welcome message

                Console.WriteLine("Please Enter a line to be translated");// Gets users input
                string userSentence = Console.ReadLine();// Reads user's input
                Console.WriteLine(userSentence.ToLower());//convert user input to Lower case  
                string transPiLatin = pigLatinTraslate(userSentence);
                Console.WriteLine(transPiLatin);
                Console.WriteLine("Translate another Line? (y/n)");// validates more input sentence from the user
                string userRes = Console.ReadLine();
                if (userRes == "Y" || userRes == "y")
                {
                    agree = true;

                }
                else
                {

                    agree = false;
                    break;
                }

            }


        }

        static int findIndexOfVowel(string input)
        {
            char[] vowel = { 'a', 'e', 'i', '0', 'u' };

            return input.IndexOfAny(vowel);


        }
        static string pigLatinTraslate(string userSentence)
        {
            const string vowel = "a, e, i, o, u";//possible lists of Vowels that can be found in the users sentences
                                                 //vovels set to constant with no changes to the vowels
            List<string> pigLatWrds = new List<string>(); //List of string words that are added to a list collection 

            foreach (string wrd in userSentence.Split(' '))//splits or breaks users string sentences into substrings            
            {
                string firstLett = wrd.Substring(0, 1);//Extract only the first characher vowel which is in index 0 
                                                       //in the first word if it starts with a vowel 
                string allOtherWrd = wrd.Substring(1, wrd.Length - 1); //extracts first characters consonant from a 
                                                                       //string in index 0 if it starts with a consonant,
                                                                       //and iterate through the last characher of the string lenght which will be at Length - 1.
                int currPosition = vowel.IndexOf(firstLett);//Returns the zero-based index of the first character of the vowel string word.
                                                            // Console.WriteLine(currPosition);

                int index = findIndexOfVowel(wrd);
                // vowel is found at 0
                if (index == 0)
                {

                    pigLatWrds.Add(wrd + "way"); //if vowel is found at position 0, add "way" to the end

                }

                else
                {

                    string  firstIndex = wrd.Substring(index);//gets character from the first vowel to the end
                    string otherIndex = wrd.Remove(index);//remove the consonant character before the first vowel
                    string all = firstIndex + otherIndex + "ay";//combine all the new string after the first vowel
                    pigLatWrds.Add(all);// add the new string to my list
                }

            }
            return string.Join(" ", pigLatWrds);//returns the new string

        }

    }

}




