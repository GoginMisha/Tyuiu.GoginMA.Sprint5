using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GoginMA.Sprint5.Task3.V22.Lib;

namespace Tyuiu.GoginMA.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\Misha\source\repos\Tyuiu.GoginMA.Sprint5\Tyuiu.GoginMA.Sprint5.Task3.V22\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
