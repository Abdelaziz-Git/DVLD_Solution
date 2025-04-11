using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte ValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClasses(LicenseClassesDTO dto)
        {
            this.LicenseClassID = dto.LicenseClassID;
            this.ClassName = dto.ClassName;
            this.ClassDescription = dto.ClassDescription;
            this.MinimumAllowedAge = dto.MinimumAllowedAge;
            this.ValidityLength = dto.ValidityLength;
            this.ClassFees = dto.ClassFees;
        }

        public static clsLicenseClasses Find(int id)
        {
            LicenseClassesDTO dto = clsLicenseClassesData.GetById(id);
            return dto == null ? null : new clsLicenseClasses(dto);
        }

        public static List<clsLicenseClasses> GetAll()
        {
            List<clsLicenseClasses> licenseClasses = new List<clsLicenseClasses>();
            foreach (LicenseClassesDTO dto in clsLicenseClassesData.GetAll())
            {
                licenseClasses.Add(new clsLicenseClasses(dto));
            }
            return licenseClasses;
        }

        private bool _Update()
        {
            LicenseClassesDTO dto = new LicenseClassesDTO(
                this.LicenseClassID,
                this.ClassName,
                this.ClassDescription,
                this.MinimumAllowedAge,
                this.ValidityLength,
                this.ClassFees
            );

            return clsLicenseClassesData.Update(dto);
        }

        public bool Save()
        {
            return _Update();
        }
    }
}
