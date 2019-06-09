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
        static void Assert(bool Condition)
        {
            if (!Condition)
            {
                throw new Exception();
            }
        } 
    }
}
