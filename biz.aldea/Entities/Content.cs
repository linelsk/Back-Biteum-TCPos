﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Content
    {
        public Content()
        {
            Evaluations = new HashSet<Evaluation>();
            ParticipantContents = new HashSet<ParticipantContent>();
            Themes = new HashSet<Theme>();
        }

        public int Id { get; set; }
        public int Training { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public int Order { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual training TrainingNavigation { get; set; }
        public virtual CatContentType TypeNavigation { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<ParticipantContent> ParticipantContents { get; set; }
        public virtual ICollection<Theme> Themes { get; set; }
    }
}