﻿using api.premier.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.SupplierPartnerProfileConsultant
{
    public class VehicleConsultantDto
    {
        public int Id { get; set; }
        public int? ConsultantContactsConsultant { get; set; }
        public int? VehicleType { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int? Year { get; set; }
        public string PlateNumber { get; set; }
        public string Color { get; set; }
        public int? Capacity { get; set; }
        public int? NumberDoor { get; set; }
        public bool? AirConditioner { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ProfileUserDto ConsultantContactsConsultantNavigation { get; set; }
        public virtual CatVehicleTypeDto VehicleTypeNavigation { get; set; }
        public virtual ICollection<DocumentVehicleConsultantDto> DocumentVehicleConsultants { get; set; }
        public virtual ICollection<PhotosVehicleConsultantDto> PhotosVehicleConsultants { get; set; }
    }
}