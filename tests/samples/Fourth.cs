using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.samples
{
    /*
    There is a text that contains N symbols, N is definitely less than 2^16. 
    Please write code that returns count of symbols “A” in the text where symbol “B” is 3 positions before “A” and symbol “C” is right next after “A”. 

    Есть текст, содержащий N символов, N определенно меньше, чем 2^16. 
    Пожалуйста, напишите код, который возвращает количество символов “A” в тексте, 
    где символ “B” находится на 3 позиции перед “A”, а символ “C” - сразу после “A”.
     */

    public class Fourth
    {
        public int CountBAC(StringBuilder text)
        {
            int result = 0;
            for (int i = 3; i < text.Length - 1; i++)
            {
                if (text[i - 3] == 'B' && text[i] == 'A' && text[i + 1] == 'C')
                {
                    result++;
                    if (text.Length >= i + 3 && text[i - 1] == 'B' && text[i + 2] == 'A' && text[i + 3] == 'C')
                    {
                        result++;
                        i += 6;
                    }
                    else i += 4;
                }
            }
            return result;
        }
    }
}
