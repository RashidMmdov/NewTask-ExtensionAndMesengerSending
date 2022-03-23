using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Taskk.Extentions
{
    static class Extentions
    {
        public static bool customContains(this string sentence, string word)
        {
            bool search = false;
            int index = 0;
            sentence = sentence.ToLower();
            word = word.ToLower();



            for (int i = 0; i < sentence.Length; i++)
            {
                if (word.Length == 1)
                {
                    char temp = word[0];
                    if (sentence[i] == temp)
                    {
                        search = true;
                    }
                }
                else
                {

                    if (sentence[i] == word[0] && sentence[i + 1] == word[1])
                    {
                        search = true;

                        index = i;


                        for (int j = 2; j < word.Length; j++)
                        {
                            if (sentence[index + 2] == word[j])
                            {
                                index++;
                                search = true;
                            }
                            else
                            {
                                search = false;
                            }
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return search;
        }
    }
}


