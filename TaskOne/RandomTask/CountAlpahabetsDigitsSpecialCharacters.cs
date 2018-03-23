using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.RandomTask
{
    class CountAlpahabetsDigitsSpecialCharacters
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter a value: ");
            string UserInput = Console.ReadLine();
            Counter(UserInput);

        }

        public static void Counter(string UserInput)
        {
            
            int Alphabetcount, DigitCount, SpecialCount;
            Alphabetcount = DigitCount = SpecialCount = 0;
            int InputLength = UserInput.Length;

            char[] ConvertToCharater = UserInput.ToCharArray();

            foreach (var character in ConvertToCharater)
            {
                if (character >= 'a' && character <= 'z' )
                {
                    Alphabetcount++;
                }

                else if(character >= '0' && character <= '9')
                {
                    DigitCount++;
                }
                else
                {
                    SpecialCount++;
                }
            }

            Console.WriteLine($"Number of Alphabet: {Alphabetcount} \n" +
                $"Number of Digits: {DigitCount} \n Number of Special Characters: {SpecialCount}" );    
        }
    }
}
