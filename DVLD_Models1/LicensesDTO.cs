using System;

namespace DVLD_Models1
{
    public class LicensesDTO
    {
        public int LicenseID { get; set; }
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

        public LicensesDTO()
        {
            LicenseID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            DriverID = -1;
            IssueDate = DateTime.Now;
            ExpiryDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0.00m;
            IssueReason = 0;
            IsActive = false;
            CreatedByUserID = -1;
        }

        public LicensesDTO(int licenseID, int applicationID, int licenseClassID, int driverID,
                           DateTime issueDate, DateTime expiryDate, string notes, decimal paidFees,
                           byte issueReason, bool isActive, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            LicenseClassID = licenseClassID;
            DriverID = driverID;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            Notes = notes;
            PaidFees = paidFees;
            IssueReason = issueReason;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }
    }
}
