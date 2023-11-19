﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GoginMA.Sprint5.Task0.V13.Lib;

namespace Tyuiu.GoginMA.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\Misha\source\repos\Tyuiu.GoginMA.Sprint5\Tyuiu.GoginMA.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
