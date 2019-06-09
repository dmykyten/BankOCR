using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            T01_file_read();
            T02_parse_digits();
        }

        static void T01_file_read()
        {
            // valid file
            var Reader = new FileReader(@"D:\Projects\Misc\Dmytryk\BankOCR\use-cases\123456789.txt");
            Assert(Reader.IsOkay);
            Assert(Reader.IsOkay == true);
            Assert(Reader.Lines.Count() == 3);

            // non existed file
            Reader = new FileReader(@"D:\Projects\Misc\Dmytryk\BankOCR\ww.txt");
            Assert(Reader.IsOkay == false);
            Assert(Reader.Lines == null);

            // not valid file
            Reader = new FileReader(@"D:\Projects\Misc\Dmytryk\BankOCR\use-cases\invalid_length.txt");
            Assert(Reader.IsOkay == false);
            Assert(Reader.Lines.Length != 0);
        }

        static void T02_parse_digits()
        {
            var Reader = new FileReader(@"D:\Projects\Misc\Dmytryk\BankOCR\use-cases\123456789.txt");
            Assert(Reader.IsOkay);
            var Lines = Reader.Lines;

            string[][] splitted = new DigitsParser().SplitLines(Lines);
            Assert(splitted.Length == 9);
            Assert(splitted[0][0] == "   ");
            Assert(splitted[0][1] == "  |");
            Assert(splitted[0][2] == "  |");

            Assert(splitted[0][0][0] == ' ');
            Assert(splitted[0][0][1] == ' ');
            Assert(splitted[0][0][2] == ' ');


            Assert(splitted[3][0] == "   ");
            Assert(splitted[3][1] == "|_|");
            Assert(splitted[3][2] == "  |");
        }

        static void Assert(bool Condition)
        {
            if (!Condition)
            {
                throw new Exception();
            }
        } 
    }
}
