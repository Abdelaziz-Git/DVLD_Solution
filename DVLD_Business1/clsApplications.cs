using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_Business1
{
    public class clsApplications
    {
        public enum enMode { AddNewMode = 0, UpdateMode = 1 }
        public enMode Mode { get; private set; } = enMode.AddNewMode;

        public int ApplicationID { get; private set; }
        public int ApplicantPersonID { get; set; }
        public int ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplications()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationTypeID = -1;
            ApplicationDate = DateTime.MinValue;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = -1;
            Mode = enMode.AddNewMode;
        }

        private clsApplications(ApplicationsDTO application)
        {
            ApplicationID = application.ApplicationID;
            ApplicantPersonID = application.ApplicantPersonID;
            ApplicationTypeID = application.ApplicationTypeID;
            ApplicationDate = application.ApplicationDate;
            ApplicationStatus = application.ApplicationStatus;
            LastStatusDate = application.LastStatusDate;
            PaidFees = application.PaidFees;
            CreatedByUserID = application.CreatedByUserID;
            Mode = enMode.UpdateMode;
        }
        public static bool PersonHasNewOrCompleted_L_D_L_ApplicationWithSameLicenseClass(int PersonID,int LicenseClass)
        {
            return clsApplicationsData.ApplicantPersonHasNewOrCompleted_L_D_L_ApplicationWithSameLicenseClass(PersonID, LicenseClass);
        }
        public static clsApplications Find(int applicationID)
        {
            ApplicationsDTO application = clsApplicationsData.GetApplicationInfoByID(applicationID);
            return (application == null) ? null : new clsApplications(application);
        }
        public static clsApplications FindByPersonID(int PersonID)
        {
            ApplicationsDTO application = clsApplicationsData.GetApplicationInfoByPersonID(PersonID);
            return (application == null) ? null : new clsApplications(application);
        }
        public bool Save()
        {
            ApplicationsDTO application = new ApplicationsDTO
            {
                ApplicationID = this.ApplicationID,
                ApplicantPersonID = this.ApplicantPersonID,
                ApplicationTypeID = this.ApplicationTypeID,
                ApplicationDate = this.ApplicationDate,
                ApplicationStatus = this.ApplicationStatus,
                LastStatusDate = this.LastStatusDate,
                PaidFees = this.PaidFees,
                CreatedByUserID = this.CreatedByUserID
            };

            switch (Mode)
            {
                case enMode.AddNewMode:
                    this.ApplicationID = clsApplicationsData.AddNewApplication(application);
                    Mode = (this.ApplicationID != -1) ? enMode.UpdateMode : enMode.AddNewMode;
                    return (this.ApplicationID != -1);
                case enMode.UpdateMode:
                    return clsApplicationsData.UpdateApplication(application);
                default:
                    return false;
            }
        }

        public static bool Delete(int applicationID)
        {
            return clsApplicationsData.DeleteApplication(applicationID);
        }

        public static List<clsApplications> GetAllApplications()
        {
            List<clsApplications> applicationsList = new List<clsApplications>();
            foreach (ApplicationsDTO application in clsApplicationsData.GetAllApplications())
            {
                applicationsList.Add(new clsApplications(application));
            }
            return applicationsList;
        }
    }
}