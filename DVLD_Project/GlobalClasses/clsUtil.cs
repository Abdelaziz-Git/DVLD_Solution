using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.GlobalClasses
{
    public class clsUtil
    {
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
    }
}
