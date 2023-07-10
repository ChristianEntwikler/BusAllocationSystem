using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusAllocationSystem
{
    public class userDto
    {
        public String userId { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String emailAddress { get; set; }
        public String address { get; set; }
        public String pwd { get; set; }
        public String busStop { get; set; }
        public String busNumber { get; set; }
        public String DateUpdated { get; set; }
        public String DateCreated { get; set; }
    }
}