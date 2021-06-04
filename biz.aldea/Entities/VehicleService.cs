﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class VehicleService
    {
        public VehicleService()
        {
            DocumentVehicleServices = new HashSet<DocumentVehicleService>();
            PhotosVehicleServices = new HashSet<PhotosVehicleService>();
        }

        public int Id { get; set; }
        public int? ConsultantContactsService { get; set; }
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

        public virtual ConsultantContactsService ConsultantContactsServiceNavigation { get; set; }
        public virtual CatVehicleType VehicleTypeNavigation { get; set; }
        public virtual ICollection<DocumentVehicleService> DocumentVehicleServices { get; set; }
        public virtual ICollection<PhotosVehicleService> PhotosVehicleServices { get; set; }
    }
}