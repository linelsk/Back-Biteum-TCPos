﻿using api.premier.Models.Catalogos;
using System;

namespace api.premier.Models.ClientPartnerProfile
{
    public class ServiceScoreAwardDto
    {
        public int Id { get; set; }
        public int IdClientPartnerProfile { get; set; }
        public int IdType { get; set; }
        public string Description { get; set; }
        public int IdServiceLine { get; set; }
        public DateTime Year { get; set; }
        public string Comment { get; set; }

        public virtual ClientPartnerProfileDto IdClientPartnerProfileNavigation { get; set; }
        public virtual CatServiceLineDto IdServiceLineNavigation { get; set; }
        public virtual CatServiceScoreAwardDto IdTypeNavigation { get; set; }
    }
}