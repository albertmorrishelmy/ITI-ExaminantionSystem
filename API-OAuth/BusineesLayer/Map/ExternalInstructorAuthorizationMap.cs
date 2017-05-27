using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Map
{
    public partial class ExternalInstructorAuthorizationMap
    {
        public int Ins_Id { get; set; }
        public int Code { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        
    }
}
