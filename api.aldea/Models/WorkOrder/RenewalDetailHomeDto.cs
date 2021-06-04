using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.WorkOrder
{
    public class RenewalDetailHomeDto
    {
        public int Id { get; set; }
        public bool? Automatically { get; set; }
        public bool? RenewalNotification { get; set; }
        public DateTime? AdditionalRentIncreaseDate { get; set; }
        public string RecurrentIncreasePeriod { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual HousingListDto IdNavigation { get; set; }
    }
}
