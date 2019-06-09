using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    class DigitsParser
    {
        public string[][] Splitted { get; set; } 
        public string[][] SplitLines(string[] Lines)
        {
            Splitted = new string[3][];
            for (int i = 0;i != 3; i++)
            {
                Splitted[i] = new string[9];
                for (int j = 0;j != 9; j++)
                {
                    for(int k = 0;k != Lines.Length; k++)
                    {
                        Splitted[i][j] = Splitted[i][j] + Lines[j][k];
                        if(k % 2 == 0)
                        {
                            j++;
                        }
                        if(j % 2 == 0)
                        {
                            i++;
                        }

                    }
                }
            }
            return null;
        }
    }
}
