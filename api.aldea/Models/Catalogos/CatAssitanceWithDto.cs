﻿using api.premier.Models.Departure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.Catalogos
{
    public class CatAssitanceWithDto
    {
        public int Id { get; set; }
        public string Assistance { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual ICollection<DepartureAssistanceWithDto> DepartureAssistanceWiths { get; set; }
    }
}