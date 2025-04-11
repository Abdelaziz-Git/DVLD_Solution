using System;

namespace DVLD_Models1
{
    public class TestsDTO
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public TestsDTO()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = null;
            CreatedByUserID = -1;
        }
    }
}