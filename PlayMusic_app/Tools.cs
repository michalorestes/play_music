using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayMusic_app
{
    static class Tools
    {
        public static string replaceCharacters(string text)
        {
            Regex pattern = new Regex("[']");
            Regex pattern2 = new Regex("[&]");
            string result = pattern2.Replace(pattern.Replace(text, "''"), @"&");
            
            
            return result; 
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);  
            }
            catch { }
            return returnImage;
        }
    }
}
