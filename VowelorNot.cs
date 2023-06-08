using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VowelorNot
    {
        public void vowel()
        {
            
                char alphabet = 'a';

                if (IsVowel(alphabet))
                {
                    Console.WriteLine(alphabet + " is a vowel.");
                }
                else
                {
                    Console.WriteLine(alphabet + " is a consonant.");
                }
            

            static bool IsVowel(char alphabet)
            {
           
                alphabet = char.ToLower(alphabet);

                if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
