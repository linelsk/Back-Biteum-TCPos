﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class AppointmentWorkOrderService
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int WorkOrderServiceId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual WorkOrderService WorkOrderService { get; set; }
    }
}