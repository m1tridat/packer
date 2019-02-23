using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace packer
{
    class Compress
    {

        public string[] files;
        public string[] folders;
        public string savePath;

        public int progressBarMaximum;
        public int progressBarValue;

        

        public static void CompressFiles()
        {
            ZipFile.CreateFromDirectory(@"D:\Pictures\arts", @"D:\Pictures\arts.zip");
        }
        

    }
}
