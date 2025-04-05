using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class TestTypesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        public TestTypesDTO()
        {
            this.Id = -1;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Fees = 0;
        }
        public TestTypesDTO(int id, string title, string description, decimal fees)
        {
            Id = id;
            Title = title;
            Description = description;
            Fees = fees;
        }


    }
}
