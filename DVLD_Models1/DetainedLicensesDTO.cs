using System;

namespace DVLD_Models1
{
    public class DetainedLicensesDTO
    {
        public int DetainedID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainedDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool? IsRelease { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public DetainedLicensesDTO()
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
        }

        public DetainedLicensesDTO(int detainedID, int licenseID, DateTime detainedDate, decimal fineFees,
                                    int createdByUserID, bool? isRelease, DateTime? releaseDate,
                                    int? releasedByUserID, int? releaseApplicationID)
        {
            DetainedID = detainedID;
            LicenseID = licenseID;
            DetainedDate = detainedDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsRelease = isRelease;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }
    }
}