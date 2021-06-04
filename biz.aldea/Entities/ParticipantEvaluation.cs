﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ParticipantEvaluation
    {
        public int Id { get; set; }
        public int? ParticipantContent { get; set; }
        public int? Question { get; set; }
        public int? Answer { get; set; }
        public bool? Correct { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Answer AnswerNavigation { get; set; }
        public virtual ParticipantContent ParticipantContentNavigation { get; set; }
        public virtual Evaluation QuestionNavigation { get; set; }
    }
}