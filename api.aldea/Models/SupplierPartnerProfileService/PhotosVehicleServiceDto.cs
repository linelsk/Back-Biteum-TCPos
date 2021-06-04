﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.SupplierPartnerProfileService
{
    public class PhotosVehicleServiceDto
    {
        public int Id { get; set; }
        public int? VehicleService { get; set; }
        public string Photo { get; set; }
        public string PhotoExtension { get; set; }
        public bool? Interior { get; set; }
        public bool? Exterior { get; set; }
        public bool? Safety { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual VehicleServiceDto VehicleServiceNavigation { get; set; }
    }
}