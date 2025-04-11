using System;

namespace DVLD_Models1
{
    public class TestAppointmentsDTO
    {
        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsLocked { get; set; }
        public int CreatedByUserID { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public TestAppointmentsDTO()
        {
            TestAppointmentID = -1;
            LocalDrivingLicenseApplicationID = -1;
            TestTypeID = -1;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0m;
            IsLocked = false;
            CreatedByUserID = -1;
            RetakeTestApplicationID = null;
        }
        public TestAppointmentsDTO(int testAppointmentID, int localDrivingLicenseApplicationID, int testTypeID, DateTime appointmentDate, decimal paidFees, bool isLocked, int createdByUserID, int? retakeTestApplicationID)
        {
            TestAppointmentID = testAppointmentID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            TestTypeID = testTypeID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            IsLocked = isLocked;
            CreatedByUserID = createdByUserID;
            RetakeTestApplicationID = retakeTestApplicationID;
        }
    }
}