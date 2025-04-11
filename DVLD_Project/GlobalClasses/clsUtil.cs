using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DVLD_Project.GlobalClasses
{
    public class clsUtil
    {
        public enum enApplicationStatus
        {
            New = 1,
            Cancelled ,
            Completed
        }
        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService,
            ReplacementforaLostDrivingLicense,
            ReplacementforaDamagedDrivingLicense,
            ReleaseDetainedDrivingLicenseService,
            NewInternationalLicense,
            RetakTest
        }
        public static string GetGUID()
        {
            return Guid.NewGuid().ToString();
        }
        public static bool CreateFolderIfNotExists(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string ReplaceFileNameWithGUID(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string newFileName = GetGUID() + extension;
            return newFileName;
        }
        public static bool CopyImageToProjectImagesFolder(ref string SourceFile)
        {
            string PeopleImagesPath = @"C:\DVLD_People_Image\";
            if(!CreateFolderIfNotExists(PeopleImagesPath))
                return false;
            string DestinationFile = PeopleImagesPath + ReplaceFileNameWithGUID(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            SourceFile = DestinationFile;
            return true;

        }

        public readonly string Key= "XexE5Zg6I9j12A15";
        public static string Encrypt(string text, string key= "XexE5Zg6I9j12A15")
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = new byte[16]; // Simple IV (should be randomized in real apps)
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray()); // Convert to readable string
                }
            }
        }
        public static string Decrypt(string text, string key= "XexE5Zg6I9j12A15")
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = new byte[16];
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(text)))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
