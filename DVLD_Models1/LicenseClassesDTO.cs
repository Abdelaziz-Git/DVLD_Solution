using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class LicenseClassesDTO
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte ValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        public LicenseClassesDTO()
        {
            LicenseClassID = -1;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = 0;
            ValidityLength = 0;
            ClassFees = 0.0m;
        }
        public LicenseClassesDTO(int id, string name, string description, byte minimumAllowedAge, byte validityLength, decimal fees)
        {
            LicenseClassID = id;
            ClassName = name;
            ClassDescription = description;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLength = validityLength;
            ClassFees = fees;
        }
    }
}
