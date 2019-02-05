using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace FileData
{
    class DefinedValues
    {
        public string[] strSize = ConfigurationManager.AppSettings["Size"].Split(',').Select(s => s.Trim()).ToArray();
        public string[] strVersion = ConfigurationManager.AppSettings["Version"].Split(',').Select(s => s.Trim()).ToArray();
        public string[] strVersionAndSize = ConfigurationManager.AppSettings["VersionAndSize"].Split(',').Select(s => s.Trim()).ToArray();
    }
}
