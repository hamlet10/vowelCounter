using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace vowelCounter
{
    public static class vowelCounter
    {

        public static IDictionary<char, int> Counter(string text)
        {
            Input_Validator(text);

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Dictionary<char, int> Vowels = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    if (Vowels.ContainsKey(text[i]))
                    {
                        Vowels.Add(text[i], 1);
                    }
                    else
                    {
                        Vowels[text[i]] += 1;
                    }
                }
            }


            return Vowels;
        }





        private static void Input_Validator(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(paramName: nameof(text));
            }

        }
    }

}


