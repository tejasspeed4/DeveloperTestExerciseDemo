using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileInfo
    {
        FileDetails clsFileDetails = new FileDetails();
        DefinedValues clsDefinedValues = new DefinedValues();
        public string FindFileVersion(string[] filedetails)
        {
            try
            {
                if (ValidateFileDetails(filedetails))
                {
                    string strFileData = "";

                    if (filedetails[0].IsOneOf(clsDefinedValues.strVersion))
                    {
                        Console.WriteLine(clsFileDetails.Version(filedetails[1]));
                        strFileData = clsFileDetails.Version(filedetails[1]);
                    }
                    else if (filedetails[0].IsOneOf(clsDefinedValues.strSize))
                    {
                        Console.WriteLine(clsFileDetails.Size(filedetails[1]));
                        strFileData = clsFileDetails.Version(filedetails[1]);
                    }
                    return strFileData;
                }
                else
                {
                    // Console.WriteLine("Invalid File");
                    return "Invalid File";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
                return "Invalid File";
            }
        }
        public bool ValidateFileDetails(string[] filedetails)
        {
            try
            {
                if (filedetails.Length != 2)
                {
                    Console.WriteLine("Invalid File");
                    return false;
                }
                else if (!(filedetails[0].IsOneOf(clsDefinedValues.strVersionAndSize)))
                {
                    Console.WriteLine("Invalid File");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
                return false;
            }
        }
    }
    static class FileSizeVerionType
    {
        public static bool IsOneOf<T>(this T value, params T[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (items[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
