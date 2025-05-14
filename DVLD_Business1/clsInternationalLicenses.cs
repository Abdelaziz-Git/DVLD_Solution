using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsInternationalLicenses
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { get; private set; }

        public int InternationalLicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicenses()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = false;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsInternationalLicenses(InternationalLicensesDTO licenseDTO)
        {
            InternationalLicenseID = licenseDTO.InternationalLicenseID;
            ApplicationID = licenseDTO.ApplicationID;
            DriverID = licenseDTO.DriverID;
            IssuedUsingLocalLicenseID = licenseDTO.IssuedUsingLocalLicenseID;
            IssueDate = licenseDTO.IssueDate;
            ExpirationDate = licenseDTO.ExpirationDate;
            IsActive = licenseDTO.IsActive;
            CreatedByUserID = licenseDTO.CreatedByUserID;
            Mode = enMode.Update;
        }

        public static clsInternationalLicenses Find(int internationalLicenseID)
        {
            InternationalLicensesDTO license = clsInternationalLicensesData.GetInternationalLicenseByID(internationalLicenseID);
            return (license == null) ? null : new clsInternationalLicenses(license);
        }

        public static clsInternationalLicenses FindByApplicationID(int applicationID)
        {
            InternationalLicensesDTO license = clsInternationalLicensesData.GetInternationalLicenseByApplicationID(applicationID);
            return (license == null) ? null : new clsInternationalLicenses(license);
        }

        public static List<clsInternationalLicenses> FindByDriverID(int driverID)
        {
            List<InternationalLicensesDTO> licensesDTO = clsInternationalLicensesData.GetInternationalLicensesByDriverID(driverID);
            return ConvertDTOsToBusinessObjects(licensesDTO);
        }

        public static List<clsInternationalLicenses> FindByIssuedUsingLocalLicenseID(int issuedUsingLocalLicenseID)
        {
            List<InternationalLicensesDTO> licensesDTO = clsInternationalLicensesData.GetInternationalLicensesByIssuedUsingLocalLicenseID(issuedUsingLocalLicenseID);
            return ConvertDTOsToBusinessObjects(licensesDTO);
        }

        public bool Save()
        {
            InternationalLicensesDTO licenseDTO = new InternationalLicensesDTO(
                InternationalLicenseID,
                ApplicationID,
                DriverID,
                IssuedUsingLocalLicenseID,
                IssueDate,
                ExpirationDate,
                IsActive,
                CreatedByUserID
            );

            switch (Mode)
            {
                case enMode.AddNew:
                    int newID = clsInternationalLicensesData.AddNewInternationalLicense(licenseDTO);
                    if (newID != -1)
                    {
                        InternationalLicenseID = newID;
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return clsInternationalLicensesData.UpdateInternationalLicense(licenseDTO);

                default:
                    return false;
            }
        }

        public static bool Delete(int internationalLicenseID)
        {
            return clsInternationalLicensesData.DeleteInternationalLicense(internationalLicenseID);
        }
        public static List<clsInternationalLicenses> GetAllInternationalLicenses()
        {
            return ConvertDTOsToBusinessObjects(clsInternationalLicensesData.GetAllInternationalLicenses());
        }
        private static List<clsInternationalLicenses> ConvertDTOsToBusinessObjects(List<InternationalLicensesDTO> licensesDTO)
        {
            List<clsInternationalLicenses> licenses = new List<clsInternationalLicenses>();
            foreach (var dto in licensesDTO)
            {
                licenses.Add(new clsInternationalLicenses(dto));
            }
            return licenses;
        }

    }
}