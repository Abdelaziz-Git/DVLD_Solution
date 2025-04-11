using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class LocalDrivingLicenseApplicationsDTO
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public LocalDrivingLicenseApplicationsDTO()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
        }

        public LocalDrivingLicenseApplicationsDTO(
            int localDrivingLicenseApplicationID,
            int applicationID,
            int licenseClassID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ApplicationID = applicationID;
            LicenseClassID = licenseClassID;
        }
    }
}
