using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;

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
    }
}