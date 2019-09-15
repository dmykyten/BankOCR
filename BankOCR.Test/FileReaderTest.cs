using System;
using System.Linq;
using BankOCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankOCR.Test
{
    [TestClass]
    public class FileReaderTest
    {
        const string root = @"C:\Github\BankOCR\useCases\";

        [TestMethod]
        public void TestMethod1()
        {
            // valid file
            var Reader = new FileReader(root + "123456789.txt");
            Assert.IsTrue(Reader.IsOkay);
            Assert.IsTrue(Reader.IsOkay == true);
            Assert.IsTrue(Reader.Lines.Count() == 3);

            // non existed file
            Reader = new FileReader(root + "ww.txt");
            Assert.IsTrue(Reader.IsOkay == false);
            Assert.IsTrue(Reader.Lines == null);

            // not valid file
            Reader = new FileReader(root + "invalid_length.txt");
            Assert.IsTrue(Reader.IsOkay == false);
            Assert.IsTrue(Reader.Lines.Length != 0);
        }
    }
}
