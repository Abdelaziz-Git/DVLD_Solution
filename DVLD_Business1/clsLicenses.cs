using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsLicenses
    {
        public enum enMode { AddNewMode = 0, UpdateMode = 1 }
        public enMode Mode { get; private set; } = enMode.AddNewMode;
        public enum enIssueReason { FirstTime = 1, Renew, ReplacementForDamaged, ReplacementForLost }
        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public int DriverID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public byte IssueReason { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public string ClassName 
        {
            get 
            {
                if (LicenseClassID == -1)
                    return string.Empty;
                else
                {
                    clsLicenseClasses licenseClass = clsLicenseClasses.Find(LicenseClassID);
                    return (licenseClass == null) ? string.Empty : licenseClass.ClassName;
                }
            }
        }

        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            DriverID = -1;
            IssueDate = DateTime.MinValue;
            ExpiryDate = DateTime.MinValue;
            Notes = string.Empty;
            PaidFees = 0;
            IssueReason = 0;
            IsActive = false;
            CreatedByUserID = -1;
            Mode = enMode.AddNewMode;
        }

        private clsLicenses(LicensesDTO license)
        {
            LicenseID = license.LicenseID;
            ApplicationID = license.ApplicationID;
            LicenseClassID = license.LicenseClassID;
            DriverID = license.DriverID;
            IssueDate = license.IssueDate;
            ExpiryDate = license.ExpiryDate;
            Notes = license.Notes;
            PaidFees = license.PaidFees;
            IssueReason = license.IssueReason;
            IsActive = license.IsActive;
            CreatedByUserID = license.CreatedByUserID;
            Mode = enMode.UpdateMode;
        }

        public static bool IsDetained(int licenseID)
        {
            return clsLicensesData.IsDetained(licenseID);
        }
        public static clsLicenses Find(int licenseID)
        {
            LicensesDTO dto = clsLicensesData.GetLicenseInfoByID(licenseID);
            return (dto == null) ? null : new clsLicenses(dto);
        }

        public static clsLicenses FindByApplicationID(int applicationID)
        {
            LicensesDTO dto = clsLicensesData.GetLicenseInfoByApplicationID(applicationID);
            return (dto == null) ? null : new clsLicenses(dto);
        }
        public static bool IsLicenseExistsByApplicationID(int applicationID)
        {
            return clsLicensesData.LicenseExistsByApplicationID(applicationID);
        }
        public static List<clsLicenses> FindByLicenseClassID(int licenseClassID)
        {
            List<clsLicenses> list = new List<clsLicenses>();
            foreach (LicensesDTO dto in clsLicensesData.GetLicensesByLicenseClassID(licenseClassID))
                list.Add(new clsLicenses(dto));
            return list;
        }

        public static List<clsLicenses> FindByDriverID(int driverID)
        {
            List<clsLicenses> list = new List<clsLicenses>();
            foreach (LicensesDTO dto in clsLicensesData.GetLicensesByDriverID(driverID))
                list.Add(new clsLicenses(dto));
            return list;
        }

        public bool Save()
        {
            LicensesDTO dto = new LicensesDTO
            {
                LicenseID = this.LicenseID,
                ApplicationID = this.ApplicationID,
                LicenseClassID = this.LicenseClassID,
                DriverID = this.DriverID,
                IssueDate = this.IssueDate,
                ExpiryDate = this.ExpiryDate,
                Notes = this.Notes,
                PaidFees = this.PaidFees,
                IssueReason = this.IssueReason,
                IsActive = this.IsActive,
                CreatedByUserID = this.CreatedByUserID
            };

            switch (Mode)
            {
                case enMode.AddNewMode:
                    this.LicenseID = clsLicensesData.AddNewLicense(dto);
                    Mode = (this.LicenseID != -1) ? enMode.UpdateMode : enMode.AddNewMode;
                    return (this.LicenseID != -1);
                case enMode.UpdateMode:
                    return clsLicensesData.UpdateLicense(dto);
                default:
                    return false;
            }
        }

        public static bool Delete(int licenseID)
        {
            return clsLicensesData.DeleteLicense(licenseID);
        }

        public static List<clsLicenses> GetAllLicenses()
        {
            List<clsLicenses> list = new List<clsLicenses>();
            foreach (LicensesDTO dto in clsLicensesData.GetAllLicenses())
                list.Add(new clsLicenses(dto));
            return list;
        }
    }
}