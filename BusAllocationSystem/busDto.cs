using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusAllocationSystem
{
    public class busDto
    {
        public String tagId { get; set; }
        public String regNo { get; set; }
        public String totalSeat { get; set; }
        public String takenSeat { get; set; }
        public String makerId { get; set; }
        public String makeStamp { get; set; }
    }
}