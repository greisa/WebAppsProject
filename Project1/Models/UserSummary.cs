using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class UserSummary : IdentityUser
    {
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string ProfPicURL { get; set; }

        public UserSummary()
        {

        }
    }
}
