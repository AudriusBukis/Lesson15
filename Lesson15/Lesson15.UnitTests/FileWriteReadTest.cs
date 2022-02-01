using Lesson15.Modules;
using System;
using System.Collections.Generic;
using Xunit;

namespace Lesson15.UnitTests
{
    public class FileWriteReadTest
    {
        [Fact]
        public void Test_If_File_WriteAllText_And_Read_File_Get_The_Same_Results()
        {
            var testWrite = new FileWriterService("Test1.txt");
            var testWritelist = new List<string>();
            var testRead = new FileReaderService("Test1.txt");
            
            testWritelist.Add("string element 1");
            testWritelist.Add("string element 2");
            testWritelist.Add("string element 3");
            testWritelist.Add("string element 4");
            testWritelist.Add("string element 5");

            testWrite.WriteAllText(testWritelist.ToArray());
            List<string> testReadlist = testRead.GetAllLines();

            Assert.True(testReadlist[0] == testWritelist[0]);
            Assert.True(testReadlist[3] == testWritelist[3]);

        }
        [Fact]
        public void Test_If_File_AppendText_And_Read_File_Get_The_Same_Results()
        {
            var testWrite = new FileWriterService("Test2.txt");
            var testWritelist = new List<string>();
            testWrite.WriteAllText(testWritelist.ToArray());
            var testRead = new FileReaderService("Test2.txt");

            testWrite.AppendText("string element 1");
            testWrite.AppendText("string element 2");
            testWrite.AppendText("string element 3");
            testWrite.AppendText("string element 4");

            List<string>  testReadlist = testRead.GetAllLines();

            Assert.True(testReadlist[0] == "string element 1");
            Assert.True(testReadlist[2] == "string element 3");

        }
    }
}
