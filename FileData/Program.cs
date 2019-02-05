using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileInfo clsFileInfo = new FileInfo();
            FileDetails clsFileDetails = new FileDetails();
            clsFileInfo.FindFileVersion(args);
            Console.ReadLine();
        }
    }
}
