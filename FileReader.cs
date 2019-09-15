using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankOCR
{
    public class FileReader
    {
        public string[] Lines { get; private set; }
        public bool IsOkay { get; private set; }
        public FileReader(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                Lines = File.ReadAllLines(FilePath);
                if(Lines.Length % 3 != 0) {
                    IsOkay = false;
                    return ;
                }
                for(int i = 0;i < Lines.Length; i++)
                {
                    if (Lines[i].Length == 27)
                    {
                        IsOkay = true;
                    }
                    else
                    {
                        IsOkay = false;
                        break;
                    }
                }
            }
            else
            {
                IsOkay = false;
            }
        }
    }
}
