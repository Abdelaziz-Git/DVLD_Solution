using DVLD_Business1;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Project.GlobalClasses
{
    public class clsGlobal
    {
        public static clsUser CurrentUser { get; set; }
        static string FilePath = @"C:\Users\Public\Credentials.txt";
        public static void RememberUsernameAndPassword(string UserName, string Password)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                Password = clsUtil.Encrypt(Password);
                try
                {
                    File.WriteAllText(FilePath, UserName + ":" + Password);

                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
            
        }   
        public static bool GetCredentials(ref string UserName, ref string Password)
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string[] Credentials = File.ReadAllText(FilePath).Split(':');
                    UserName = Credentials[0];
                    Password = clsUtil.Decrypt(Credentials[1]);
                    return true;
                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
            return false;
        }
    }
}
