using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business1
{
    public class clsTestTypes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        private clsTestTypes(TestTypesDTO TestType)
        {
            this.Id = TestType.Id;
            this.Title = TestType.Title;
            this.Description = TestType.Description;
            this.Fees = TestType.Fees;
        }
        public static clsTestTypes Find(int AppTypId)
        {
            return new clsTestTypes(clsTestTypesData.GetById(AppTypId));
        }
        public static List<clsTestTypes> GetAll()
        {
            List<clsTestTypes> TestTypes = new List<clsTestTypes>();
            foreach (TestTypesDTO TestType in clsTestTypesData.GetAll())
            {
                TestTypes.Add(new clsTestTypes(TestType));
            }
            return TestTypes;
        }
        private bool _Update()
        {
            return clsTestTypesData.Update(new TestTypesDTO(this.Id, this.Title, this.Description, this.Fees));
        }
        public bool Save()
        {
            return _Update();
        }
    }
}
