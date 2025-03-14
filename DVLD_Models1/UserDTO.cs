using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Models1
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Salt { get; set; }
        public bool IsActive { get; set; }
        public int Permissions { get; set; }
    }
}
