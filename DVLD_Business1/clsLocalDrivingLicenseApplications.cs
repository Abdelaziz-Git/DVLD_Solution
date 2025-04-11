using DVLD_DataAccess1;
using DVLD_Models1;
using System.Collections.Generic;
using System.Data;

namespace DVLD_Business1
{
    public class clsLocalDrivingLicenseApplications
    {
        public enum enMode { AddNew=0, Update=1 }
        public enMode Mode { get; private set; }

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationsDTO dto)
        {
            LocalDrivingLicenseApplicationID = dto.LocalDrivingLicenseApplicationID;
            ApplicationID = dto.ApplicationID;
            LicenseClassID = dto.LicenseClassID;
            Mode = enMode.Update;
        }

        public static clsLocalDrivingLicenseApplications Find(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplicationsDTO dto = clsLocalDrivingLicenseApplicationsData.GetInfoByID(localDrivingLicenseApplicationID);
            return dto == null ? null : new clsLocalDrivingLicenseApplications(dto);
        }

        public bool Save()
        {
            LocalDrivingLicenseApplicationsDTO dto = new LocalDrivingLicenseApplicationsDTO(
                LocalDrivingLicenseApplicationID,
                ApplicationID,
                LicenseClassID
            );

            switch (Mode)
            {
                case enMode.AddNew:
                    this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsData.AddNew(dto);
                    Mode = (this.LocalDrivingLicenseApplicationID != -1) ? enMode.Update : enMode.AddNew;
                    return (this.LocalDrivingLicenseApplicationID != -1);

                case enMode.Update:
                    return clsLocalDrivingLicenseApplicationsData.Update(dto);

                default:
                    return false;
            }
        }

        public static bool Delete(int localDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsData.Delete(localDrivingLicenseApplicationID);
        }

        public static List<clsLocalDrivingLicenseApplications> GetAll()
        {
            List<LocalDrivingLicenseApplicationsDTO> dtos = clsLocalDrivingLicenseApplicationsData.GetAll();
            return dtos.ConvertAll(dto => new clsLocalDrivingLicenseApplications(dto));
        }
        public static DataView GetAllDataView()
        {
            return clsLocalDrivingLicenseApplicationsData.LocalDrivingLicenseApplicationsDataView();
        }
    }
}