using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsProfilePic { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }

        public Photo()
        { 
            
        }
    }
}
