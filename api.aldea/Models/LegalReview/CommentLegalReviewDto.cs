﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.LegalReview
{
    public class CommentLegalReviewDto
    {
        public int Id { get; set; }
        public int? LegalReviewId { get; set; }
        public string Reply { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual LegalReviewDto LegalReview { get; set; }
        public virtual UserDto User { get; set; }
    }
}