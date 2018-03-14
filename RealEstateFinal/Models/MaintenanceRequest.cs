using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateFinal.Models
{
    public class MaintenanceRequest
    {
        public int ID { get; set; }
        public string Requestor { get; set; }
        public string PropertyAddress { get; set; }
        public int UnitNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateRequested { get; set; }
    }
}
