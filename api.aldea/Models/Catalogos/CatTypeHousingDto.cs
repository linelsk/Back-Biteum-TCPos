﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.Catalogos
{
    public class CatTypeHousingDto
    {
        public int Id { get; set; }
        public string TypeHousing { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}