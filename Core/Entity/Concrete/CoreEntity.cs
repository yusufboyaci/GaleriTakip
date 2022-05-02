using Core.Entity.Abstract;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete
{
    public class CoreEntity : IEntity<Guid>
    {
        public CoreEntity()
        {
            Status = Status.None;
            CreatedDate = DateTime.Now;
            CreatedADUserName = WindowsIdentity.GetCurrent().Name;
            CreatedComputerName = Environment.MachineName;
            CreatedIP = "127.0.0.1";
            CreatedBy = 1;
        }
        public Guid Id { get; set; }
        public Guid? MasterId { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedADUserName { get; set; }
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIP { get; set; }
        public string ModifiedADUserName { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
