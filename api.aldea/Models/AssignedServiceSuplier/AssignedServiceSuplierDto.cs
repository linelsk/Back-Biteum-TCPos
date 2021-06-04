using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.AssignedServiceSuplier
{
    public class AssignedServiceSuplierDto
    {
        public int Id { get; set; }
        public int? ImmigrationSupplierPartnerId { get; set; }
        public int? RelocationSupplierPartnerId { get; set; }
        public int? ServiceOrderServicesId { get; set; }
    }
}
