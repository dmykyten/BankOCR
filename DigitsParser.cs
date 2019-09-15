using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    class DigitsParser
    {
        public class UparsedNumber
        {
            string[] Lines = new string[3];

            public bool IsLengthValid()
            {
                if (Lines.Length != 3)
                {
                    return false;
                }
                for(int i =0; i != 3; i++)
                {
                    if (Lines[i].Length != 3)
                    {
                        return false;
                    }
                }
                return true;
            }

            // the same as IsLengthValid but via System.Linq
            public bool IsLengthValid2()
            {
                return Lines.Length == 3 &&
                    Lines.All(i => i.Length == 3);
            }
        }


        public UparsedNumber[] SplitLines(string[] Lines)
        {
            var result = new UparsedNumber[9]; 
            for(int i =0; i != 9; i++)
            {
                result[i] = new UparsedNumber();
            }

            for (int i = 0;i != 3; i++)
            {
                for (int j = 0;j != 9; j++)
                {
                    // TODO: Finish me
                    throw new NotImplementedException("Finish me");
                }
            }
            return result;
        }
    }
}
