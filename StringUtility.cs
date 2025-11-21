using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarizing_Text
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 15)
        {
            if (sentence.Length < maxLength)
                return sentence;



            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summarWords = new List<string>();

            foreach (var word in words)
            {
                summarWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;

            }
            var summary = string.Join(" ", summarWords) + "...";                    
            return summary;


        }
    
    }
}
