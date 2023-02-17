using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoding
{
    internal class VowelAndConsonent
    {
        public static void CheckString() {
            string ch;
            int i, len, vowels, consonants;

            ch = "BridgeLabsSolution";
            vowels = 0;
            consonants = 0;
            len = ch.Length;

            
            for (i = 0; i < len; i++)
            {

               
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i] == 'A' ||


                    ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')

                {
                    vowels++;
                }

                else if ((ch[i] >= 'a' && ch[i] <= 'z') ||
                         (ch[i] >= 'A' &&ch[i] <= 'Z'))
                {
                    consonants++;
                }
            }

            
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        }
    
    }
}
