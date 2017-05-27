using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Map
{
    public partial class InstructorsConnectionIdMap
    {
        public int Ins_Id { get; set; }
        public System.Guid Connection_Ids { get; set; }
        
    }
}
