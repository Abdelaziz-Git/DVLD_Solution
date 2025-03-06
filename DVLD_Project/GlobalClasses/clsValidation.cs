using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD_Project.GlobalClasses
{
    public class clsValidation
    {
        public static bool IsValidEmail(string Email)
        {
            string regexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(Email, regexPattern);
        }
    }
}
