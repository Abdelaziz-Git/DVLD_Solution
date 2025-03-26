using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class ApplicationTypeDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public ApplicationTypeDTO()
        {
            this.ID = -1;
            this.Title = string.Empty;
            this.Fees = 0;
        }
        public ApplicationTypeDTO(int Id,string title,decimal fees)
        {
            this.ID = Id;
            this.Title = title;
            this.Fees = fees;
        }
    }
}
