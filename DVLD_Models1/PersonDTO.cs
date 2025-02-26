using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class PersonDTO
    {
        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public byte Gender { get; set; }
        public string ImagePath { get; set; }
        public short CountryID { get; set; }

    }
}
