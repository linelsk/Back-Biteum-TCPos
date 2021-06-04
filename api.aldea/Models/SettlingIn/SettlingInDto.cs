using api.premier.Models.Catalogos;
using api.premier.Models.SupplierPartnerProfileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.SettlingIn
{
    public class SettlingInDto
    {
        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public bool? Coordination { get; set; }
        public int StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public bool? BankAccount { get; set; }
        public string BankName { get; set; }
        public DateTime? BankCompleted { get; set; }
        public bool? CarPurchaseLease { get; set; }
        public DateTime? CarCompleted { get; set; }
        public bool? DriverLicense { get; set; }
        public DateTime? DriverLicenseCompleted { get; set; }
        public bool? CleaningServices { get; set; }
        public DateTime? CleaningServicesCompleted { get; set; }
        public int? CleaningServicesSupplierPartner { get; set; }
        public string CleaningServicesSupplier { get; set; }
        public bool? ChildCare { get; set; }
        public DateTime? ChildCareCompleted { get; set; }
        public int? ChildCareSupplierPartner { get; set; }
        public string ChildCareSupplier { get; set; }
        public bool? RecreationalClub { get; set; }
        public DateTime? RecreationalClubCompleted { get; set; }
        public bool? HealthCare { get; set; }
        public DateTime? HealthCareCompleted { get; set; }
        public bool? LeisureClubMembership { get; set; }
        public DateTime? LeisureClubMembershipCompleted { get; set; }
        public bool? LocalRegistration { get; set; }
        public DateTime? LocalRegistrationCompleted { get; set; }
        public bool? SpousalAssistance { get; set; }
        public DateTime? SpousalAssistanceCompleted { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual CatStatusWorkOrderDto Status { get; set; }
        public virtual ICollection<CommentSettlingInDto> CommentSettlingIns { get; set; }
        public virtual ICollection<DocumentSettlingInDto> DocumentSettlingIns { get; set; }
        //public virtual ICollection<ExtensionSettlingInDto> ExtensionSettlingIns { get; set; }
        public virtual ICollection<ReminderSettlingInDto> ReminderSettlingIns { get; set; }
    }

    public partial class SettlingInSelectDto
    {
        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public bool? Coordination { get; set; }
        public int StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public bool? BankAccount { get; set; }
        public string BankName { get; set; }
        public DateTime? BankCompleted { get; set; }
        public bool? CarPurchaseLease { get; set; }
        public DateTime? CarCompleted { get; set; }
        public bool? DriverLicense { get; set; }
        public DateTime? DriverLicenseCompleted { get; set; }
        public bool? CleaningServices { get; set; }
        public DateTime? CleaningServicesCompleted { get; set; }
        public int? CleaningServicesSupplierPartner { get; set; }
        public string CleaningServicesSupplier { get; set; }
        public bool? ChildCare { get; set; }
        public DateTime? ChildCareCompleted { get; set; }
        public int? ChildCareSupplierPartner { get; set; }
        public string ChildCareSupplier { get; set; }
        public bool? RecreationalClub { get; set; }
        public DateTime? RecreationalClubCompleted { get; set; }
        public bool? HealthCare { get; set; }
        public DateTime? HealthCareCompleted { get; set; }
        public bool? LeisureClubMembership { get; set; }
        public DateTime? LeisureClubMembershipCompleted { get; set; }
        public bool? LocalRegistration { get; set; }
        public DateTime? LocalRegistrationCompleted { get; set; }
        public bool? SpousalAssistance { get; set; }
        public DateTime? SpousalAssistanceCompleted { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual SupplierPartnerProfileServiceDto ChildCareSupplierPartnerNavigation { get; set; }
        public virtual SupplierPartnerProfileServiceDto CleaningServicesSupplierPartnerNavigation { get; set; }
        public virtual CatStatusWorkOrderDto Status { get; set; }
        //public virtual WorkOrderService WorkOrderServices { get; set; }
        public virtual ICollection<CommentSettlingInSelectDto> CommentSettlingIns { get; set; }
        public virtual ICollection<DocumentSettlingInSelectDto> DocumentSettlingIns { get; set; }
        public virtual ICollection<ExtensionSettlingInDto> ExtensionSettlingIns { get; set; }
        public virtual ICollection<ReminderSettlingInDto> ReminderSettlingIns { get; set; }
    }
}
