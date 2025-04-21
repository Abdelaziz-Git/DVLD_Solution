using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DVLD_Business1
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { get; private set; }

        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsLocked { get; set; }
        public int CreatedByUserID { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            LocalDrivingLicenseApplicationID = -1;
            TestTypeID = -1;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0m;
            IsLocked = false;
            CreatedByUserID = -1;
            RetakeTestApplicationID = null;
            Mode = enMode.AddNew;
        }

        private clsTestAppointments(TestAppointmentsDTO dto)
        {
            TestAppointmentID = dto.TestAppointmentID;
            LocalDrivingLicenseApplicationID = dto.LocalDrivingLicenseApplicationID;
            TestTypeID = dto.TestTypeID;
            AppointmentDate = dto.AppointmentDate;
            PaidFees = dto.PaidFees;
            IsLocked = dto.IsLocked;
            CreatedByUserID = dto.CreatedByUserID;
            RetakeTestApplicationID = dto.RetakeTestApplicationID;
            Mode = enMode.Update;
        }

        public static clsTestAppointments Find(int testAppointmentID)
        {
            TestAppointmentsDTO dto = clsTestAppointmentsData.GetTestAppointmentInfoByID(testAppointmentID);
            return dto == null ? null : new clsTestAppointments(dto);
        }
        public static byte GetTrialCount(int localDrivingLicenseApplicationID,int testTypeID)
        {
            return clsTestAppointmentsData.GetNumberOfTrials(localDrivingLicenseApplicationID, testTypeID);
        }
        public static List<clsTestAppointments> GetTestAppointmentsByLDLA_and_TestTypeID(int localDrivingLicenseApplicationID,int TestTypeID)
        {
            List<clsTestAppointments> appointmentsList = new List<clsTestAppointments>();
            foreach(TestAppointmentsDTO dto in clsTestAppointmentsData.GetTestAppointments(localDrivingLicenseApplicationID, TestTypeID))
            {
                appointmentsList.Add(new clsTestAppointments(dto));
            }
            return appointmentsList;
        }
        public bool Save()
        {
            TestAppointmentsDTO dto = new TestAppointmentsDTO
            {
                TestAppointmentID = this.TestAppointmentID,
                LocalDrivingLicenseApplicationID = this.LocalDrivingLicenseApplicationID,
                TestTypeID = this.TestTypeID,
                AppointmentDate = this.AppointmentDate,
                PaidFees = this.PaidFees,
                IsLocked = this.IsLocked,
                CreatedByUserID = this.CreatedByUserID,
                RetakeTestApplicationID = this.RetakeTestApplicationID
            };

            switch (Mode)
            {
                case enMode.AddNew:
                    this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(dto);
                    Mode = this.TestAppointmentID != -1 ? enMode.Update : enMode.AddNew;
                    return this.TestAppointmentID != -1;

                case enMode.Update:
                    return clsTestAppointmentsData.UpdateTestAppointment(dto);

                default:
                    return false;
            }
        }
        public static bool Delete(int testAppointmentID)
        {
            return clsTestAppointmentsData.DeleteTestAppointment(testAppointmentID);
        }
        public static List<clsTestAppointments> GetAllTestAppointments()
        {
            List<clsTestAppointments> appointmentsList = new List<clsTestAppointments>();

            foreach (TestAppointmentsDTO dto in clsTestAppointmentsData.GetAllTestAppointments())
            {
                appointmentsList.Add(new clsTestAppointments(dto));
            }

            return appointmentsList;
        }
        public static async Task<bool> HasTestAppointments(int LocalDrivingLicenseApplication,int TestTypeID)
        {
            return await Task.Run(() => GetTestAppointmentsByLDLA_and_TestTypeID
            (LocalDrivingLicenseApplication, TestTypeID).Count > 0);
        }
        public static async Task<bool> HasOpenTestAppointments(int LocalDrivingLicenseApplication, int TestTypeID)
        {
            return await Task.Run(() => GetTestAppointmentsByLDLA_and_TestTypeID
            (LocalDrivingLicenseApplication, TestTypeID).Count(x => x.IsLocked == false) > 0);
        }
        public static async Task<bool> HasLockedTestAppointments(int LocalDrivingLicenseApplication, int TestTypeID)
        {
            return await Task.Run(() => GetTestAppointmentsByLDLA_and_TestTypeID
            (LocalDrivingLicenseApplication, TestTypeID).Count(x => x.IsLocked == true) > 0);
        }
        public static int CreateRetakeTestApplication(int LocalDrivingLicenseApplicationID,int CurrentUserID)
        {
            clsApplications OldApplication = clsApplications.Find(LocalDrivingLicenseApplicationID);
            clsApplications NewApplication = new clsApplications()
            {
                ApplicantPersonID = OldApplication.ApplicantPersonID,
                ApplicationStatus = 1, // Assuming 1 is the status for New
                ApplicationTypeID = 7, // Assuming 7 is the type for RetakeTest
                ApplicationDate = DateTime.Now,
                CreatedByUserID = CurrentUserID,
                LastStatusDate = DateTime.Now,
                PaidFees = clsApplicationType.Find(7).Fees // Assuming 7 is the type for RetakeTest
            };
            return NewApplication.Save() ? NewApplication.ApplicationID : -1;
        }
    }
}