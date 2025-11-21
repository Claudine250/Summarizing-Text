using System;
using Summarizing_Text;
namespace summarizeTxt
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var sentence = "this is going to be a long text textssssssssssssssssssssssssss";
             // create new static method
             var summary =StringUtility.SummarizeText(sentence, 30);
             Console.WriteLine(summary); */

            Console.Write("Enter sencentence: ");
            var sentence = Console.ReadLine();
            var summary = StringUtility.SummarizeText(sentence, 3);
            Console.WriteLine(summary);
        }
            
        }
    }
