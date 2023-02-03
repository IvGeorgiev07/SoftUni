﻿using System;
using System.IO;

namespace CopyBinaryFile
{
    using System;
    using System.Text;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            File.Copy(inputFilePath, outputFilePath);
        }
    }
}
