using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class ApplicationsDTO
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public int ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public ApplicationsDTO()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationTypeID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0.00m;
            CreatedByUserID = -1;
        }
        public ApplicationsDTO(int applicationID, int applicantPersonID, int applicationTypeID, DateTime applicationDate,
            byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationTypeID = applicationTypeID;
            ApplicationDate = applicationDate;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
        }
    }
}
