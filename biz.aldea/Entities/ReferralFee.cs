﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ReferralFee
    {
        public ReferralFee()
        {
            ClientPartnerProfiles = new HashSet<ClientPartnerProfile>();
            GeneralContractPricingInfos = new HashSet<GeneralContractPricingInfo>();
        }

        public int Id { get; set; }
        public string ReferralFee1 { get; set; }

        public virtual ICollection<ClientPartnerProfile> ClientPartnerProfiles { get; set; }
        public virtual ICollection<GeneralContractPricingInfo> GeneralContractPricingInfos { get; set; }
    }
}