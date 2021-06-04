﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ChatConversationImmigrationRelocation
    {
        public ChatConversationImmigrationRelocation()
        {
            ChatImmigrationRelocations = new HashSet<ChatImmigrationRelocation>();
        }

        public int Id { get; set; }
        public int ServiceLineId { get; set; }
        public int? ServiceRecordId { get; set; }
        public bool Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual CatServiceLine ServiceLine { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
        public virtual ICollection<ChatImmigrationRelocation> ChatImmigrationRelocations { get; set; }
    }
}