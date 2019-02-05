using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace DevDemoUnitTest
{
    [TestClass]
    public class DeveloperUnitTest
    {      
        FileInfo clsFileInfo = new FileInfo();

        [TestMethod]
        public void SizeValidate()
        {
            string[] strArgs = { "-s", "c:/test.txt" };
            Assert.IsNotNull(strArgs[0]);
            Assert.IsTrue(clsFileInfo.ValidateFileDetails(strArgs));
        }

        [TestMethod]
        public void VersionValidate()
        {
            string[] strArgs = { "-v", "c:/test.txt" };
            Assert.IsNotNull(strArgs[0]);
            Assert.IsTrue(clsFileInfo.ValidateFileDetails(strArgs));
        }

        [TestMethod]
        public void VersionDetails()
        {
            string[] strArgs = { "-v", "c:/test.txt" };
            string actual = clsFileInfo.FindFileVersion(strArgs);
            Assert.AreNotEqual("Invalid File", actual);
        }

        [TestMethod]
        public void SizeDetails()
        {
            string[] strArgs = { "-s", "c:/test.txt" };
            string actual = clsFileInfo.FindFileVersion(strArgs);
            Assert.AreNotEqual("Invalid File", actual);
        }
    }
}
