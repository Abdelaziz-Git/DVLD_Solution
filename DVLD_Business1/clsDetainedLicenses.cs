using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsDetainedLicenses
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { get; private set; }

        public int DetainedID { get; private set; }
        public int LicenseID { get; set; }
        public DateTime DetainedDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool? IsRelease { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }
        public clsLicenses LicenseInfo { get { return clsLicenses.Find(LicenseID); } }
        public clsDrivers DriverInfo { get { return clsDrivers.Find(LicenseInfo.DriverID); } }
        public clsPerson PersonInfo { get { return clsPerson.Find(DriverInfo.PersonID); } }

        public clsDetainedLicenses()
        {
            DetainedID = -1;
            LicenseID = -1;
            DetainedDate = DateTime.MinValue;
            FineFees = 0;
            CreatedByUserID = -1;
            IsRelease = null;
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;
            Mode = enMode.AddNew;
        }

        private clsDetainedLicenses(DetainedLicensesDTO licenseDTO)
        {
            DetainedID = licenseDTO.DetainedID;
            LicenseID = licenseDTO.LicenseID;
            DetainedDate = licenseDTO.DetainedDate;
            FineFees = licenseDTO.FineFees;
            CreatedByUserID = licenseDTO.CreatedByUserID;
            IsRelease = licenseDTO.IsRelease;
            ReleaseDate = licenseDTO.ReleaseDate;
            ReleasedByUserID = licenseDTO.ReleasedByUserID;
            ReleaseApplicationID = licenseDTO.ReleaseApplicationID;
            Mode = enMode.Update;
        }

        public static clsDetainedLicenses Find(int detainedID)
        {
            DetainedLicensesDTO license = clsDetainedLicensesData.GetDetainedLicenseByID(detainedID);
            return (license == null) ? null : new clsDetainedLicenses(license);
        }

        public static clsDetainedLicenses FindByLicenseID(int licenseID)
        {
            DetainedLicensesDTO license = clsDetainedLicensesData.GetDetainedLicenseByLicenseID(licenseID);
            return (license == null) ? null : new clsDetainedLicenses(license);
        }

        public bool Save()
        {
            DetainedLicensesDTO licenseDTO = new DetainedLicensesDTO(
                DetainedID,
                LicenseID,
                DetainedDate,
                FineFees,
                CreatedByUserID,
                IsRelease,
                ReleaseDate,
                ReleasedByUserID,
                ReleaseApplicationID
            );

            switch (Mode)
            {
                case enMode.AddNew:
                    int newID = clsDetainedLicensesData.AddNewDetainedLicense(licenseDTO);
                    if (newID != -1)
                    {
                        DetainedID = newID;
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return clsDetainedLicensesData.UpdateDetainedLicense(licenseDTO);

                default:
                    return false;
            }
        }

        public static bool Delete(int detainedID)
        {
            return clsDetainedLicensesData.DeleteDetainedLicense(detainedID);
        }

        public static List<clsDetainedLicenses> GetAllDetainedLicenses()
        {
            return ConvertDTOsToBusinessObjects(clsDetainedLicensesData.GetAllDetainedLicenses());
        }

        private static List<clsDetainedLicenses> ConvertDTOsToBusinessObjects(List<DetainedLicensesDTO> licensesDTO)
        {
            List<clsDetainedLicenses> licenses = new List<clsDetainedLicenses>();
            foreach (var dto in licensesDTO)
            {
                licenses.Add(new clsDetainedLicenses(dto));
            }
            return licenses;
        }
    }
}