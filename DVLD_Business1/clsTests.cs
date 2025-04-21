using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsTests
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { get; private set; }

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = null;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTests(TestsDTO dto)
        {
            TestID = dto.TestID;
            TestAppointmentID = dto.TestAppointmentID;
            TestResult = dto.TestResult;
            Notes = dto.Notes;
            CreatedByUserID = dto.CreatedByUserID;
            Mode = enMode.Update;
        }

        public static clsTests Find(int testID)
        {
            TestsDTO dto = clsTestsData.GetTestByID(testID);
            return dto == null ? null : new clsTests(dto);
        }
        public static clsTests FindByAppointmentID(int testAppointmentID)
        {
            TestsDTO dto = clsTestsData.GetTestByAppointmentID(testAppointmentID);
            return dto == null ? null : new clsTests(dto);
        }
        public bool Save()
        {
            TestsDTO dto = new TestsDTO
            {
                TestID = this.TestID,
                TestAppointmentID = this.TestAppointmentID,
                TestResult = this.TestResult,
                Notes = this.Notes,
                CreatedByUserID = this.CreatedByUserID
            };

            switch (Mode)
            {
                case enMode.AddNew:
                    this.TestID = clsTestsData.AddNewTest(dto);
                    Mode = this.TestID != -1 ? enMode.Update : enMode.AddNew;
                    return this.TestID != -1;

                case enMode.Update:
                    return clsTestsData.UpdateTest(dto);

                default:
                    return false;
            }
        }

        public static bool Delete(int testID)
        {
            return clsTestsData.DeleteTest(testID);
        }

        public static List<clsTests> GetAllTests()
        {
            List<TestsDTO> testsDTO = clsTestsData.GetAllTests();
            List<clsTests> testsList = new List<clsTests>();

            foreach (TestsDTO dto in testsDTO)
            {
                testsList.Add(new clsTests(dto));
            }

            return testsList;
        }
    }
}