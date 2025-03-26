using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business1
{
    public class clsApplicationType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        private clsApplicationType(ApplicationTypeDTO applicationType)
        {
            this.Id = applicationType.ID;
            this.Title = applicationType.Title;
            this.Fees = applicationType.Fees;
        }
        public static clsApplicationType Find(int AppTypId)
        {
            return new clsApplicationType(clsApplicationTypeData.GetById(AppTypId));
        }
        public static List<clsApplicationType>GetAll()
        {
            List<clsApplicationType> applicationsTypes=new List<clsApplicationType>();
            foreach(ApplicationTypeDTO applicationType in clsApplicationTypeData.GetAll())
            {
                applicationsTypes.Add(new clsApplicationType(applicationType));
            }
            return applicationsTypes;
        }
        private bool _Update()
        {
            return clsApplicationTypeData.Update(new ApplicationTypeDTO(this.Id, this.Title, this.Fees));
        }
        public bool Save()
        {
            return _Update();
        }
    }
}
