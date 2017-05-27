using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Map
{
    public partial class NotificationMap
    {
        public int Notification_Id { get; set; }
        public string Notification_Text { get; set; }
        public Nullable<bool> Is_Read { get; set; }
        public Nullable<System.DateTime> Creation_Time { get; set; }
        
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<StudentBasicData> StudentBasicDatas { get; set; }
        public virtual ICollection<Employee> Employees1 { get; set; }
    }
}
