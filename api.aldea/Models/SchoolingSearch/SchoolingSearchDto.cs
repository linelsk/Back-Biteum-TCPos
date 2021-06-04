using api.premier.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.SchoolingSearch
{
    public class SchoolingSearchDto
    {
        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public bool? Coordination { get; set; }
        public int StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual CatStatusDto Status { get; set; }
        public virtual ICollection<CommentSchoolingSearchDto> CommentSchoolingSearches { get; set; }
        public virtual ICollection<DocumentSchoolingSearchDto> DocumentSchoolingSearches { get; set; }
        public virtual ICollection<ReminderSchoolingSearchDto> ReminderSchoolingSearches { get; set; }
        public virtual ICollection<SchoolingInformationDto> SchoolingInformations { get; set; }
    }
    public partial class SchoolingSearchSelectDto
    {
        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public bool? Coordination { get; set; }
        public int StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatStatusWorkOrderDto Status { get; set; }
        //public virtual WorkOrderServiceDto WorkOrderServices { get; set; }
        public virtual ICollection<CommentSchoolingSearchSelectDto> CommentSchoolingSearches { get; set; }
        public virtual ICollection<DocumentSchoolingSearchSelectDto> DocumentSchoolingSearches { get; set; }
        public virtual ICollection<ExtensionSchoolingSearchDto> ExtensionSchoolingSearches { get; set; }
        public virtual ICollection<ReminderSchoolingSearchDto> ReminderSchoolingSearches { get; set; }
        public virtual ICollection<SchoolingInformationDto> SchoolingInformations { get; set; }
    }
}
