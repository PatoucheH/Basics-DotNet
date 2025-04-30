using System.Runtime.InteropServices;

namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string word)
        {
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);
            string reversedWord = new string(letters);
            return reversedWord;
        }


        public static string CountVowels(string message)
        {
                HashSet<char> foundVowels = new HashSet<char>();
                message = message.ToLower();
                char[] arrayMessage = message.ToCharArray();


                foreach (char letter in arrayMessage)
                {
                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'y':
                            foundVowels.Add(letter);
                            break;
                    }
                }
            
                if(foundVowels.Count() > 0) return $"Number of vowels:{foundVowels.Count()}";
                else throw new ArgumentException("Input string must not be empty");
        }

        public static string IsPalindrome(string word)
        {
            word = word.ToLower();
            word = String.Join("", word.Split(' '));
            string reversedString = ReversedString(word);
            Console.WriteLine(reversedString);
            Console.WriteLine(word);
            if (reversedString == word)
            {
                return "This is a palindrome.";
            }
            else
            {
                return "This is not a palindrome.";
            }
        }


        public static char FirstNonRepeatingCharacter(string word)
        {
            word = word.ToLower();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (char c in word)
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }
            throw new InvalidOperationException("No non-repeating character found.");

        }
    }
}
