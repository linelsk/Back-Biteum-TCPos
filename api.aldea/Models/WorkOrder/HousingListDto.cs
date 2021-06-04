using api.premier.Models.Catalogos;
using api.premier.Models.HousingSpecification;
using api.premier.Models.PropertyReport;
using api.premier.Models.ServiceOrder;
using api.premier.Models.SupplierPartnerProfileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.WorkOrder
{
    public class HousingListDto
    {
        public int Id { get; set; }
        public int? WorkOrder { get; set; }
        public int? Service { get; set; }
        public int? ServiceType { get; set; }
        public int? PropertyNo { get; set; }
        public int? SupplierPartner { get; set; }
        public int? Supplier { get; set; }
        public DateTime? VisitDate { get; set; }
        public int? HousingStatus { get; set; }
        public int? PropertyType { get; set; }
        public string Address { get; set; }
        public int? Zip { get; set; }
        public string WebSite { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? ParkingSpaces { get; set; }
        public decimal? Price { get; set; }
        public int? Currency { get; set; }
        public string AdditionalComments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual CatCurrencyDto CurrencyNavigation { get; set; }
        //public virtual CatStatusHousingDto HousingStatusNavigation { get; set; }
        //public virtual CatPropertyTypeHousingDto PropertyTypeNavigation { get; set; }
        //public virtual CatSupplierDto SupplierNavigation { get; set; }
        //public virtual CatSupplierCompanyDto SupplierPartnerNavigation { get; set; }
        //public virtual WorkOrderDto WorkOrderNavigation { get; set; }
        public virtual ContractDetailDto ContractDetail { get; set; }
        public virtual DepartureDetailsHomeDto DepartureDetailsHome { get; set; }
        public virtual LandlordDetailsHomeDto LandlordDetailsHome { get; set; }
        public virtual RenewalDetailHomeDto RenewalDetailHome { get; set; }
        public virtual ICollection<AmenitiesHousingListDto> AmenitiesHousingLists { get; set; }
        public virtual ICollection<CommentHousingDto> CommentHousings { get; set; }
        public virtual ICollection<DocumentHousingDto> DocumentHousings { get; set; }
        public virtual ICollection<HousingStatusHistoryDto> HousingStatusHistories { get; set; }
        public virtual ICollection<CostSavingHomeDto> CostSavingHomes { get; set; }
        public virtual ICollection<HousingReportDto> HousingReports { get; set; }
        public virtual ICollection<InspectionDto> Inspections { get; set; }
        public virtual ICollection<PaymentHousingDto> PaymentHousings { get; set; }
        public virtual ICollection<PropertyReportDto> PropertyReports { get; set; }
        public virtual ICollection<RepairDto> Repairs { get; set; }
    }

    public class HousingListSelectDto
    {
        public int Id { get; set; }
        public int? WorkOrder { get; set; }
        public int? Service { get; set; }
        public int? ServiceType { get; set; }
        public int? PropertyNo { get; set; }
        public int? SupplierPartner { get; set; }
        public int? Supplier { get; set; }
        public DateTime? VisitDate { get; set; }
        public int? HousingStatus { get; set; }
        public int? PropertyType { get; set; }
        public string Address { get; set; }
        public int? Zip { get; set; }
        public string WebSite { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? ParkingSpaces { get; set; }
        public decimal? Price { get; set; }
        public int? Currency { get; set; }
        public string AdditionalComments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCurrencyDto CurrencyNavigation { get; set; }
        public virtual CatStatusHousingDto HousingStatusNavigation { get; set; }
        public virtual CatPropertyTypeHousingDto PropertyTypeNavigation { get; set; }
        public virtual ConsultantContactsServiceDto SupplierNavigation { get; set; }
        public virtual SupplierPartnerProfileServiceDto SupplierPartnerNavigation { get; set; }
        public virtual WorkOrderDto WorkOrderNavigation { get; set; }
        public virtual ContractDetailDto ContractDetail { get; set; }
        public virtual DepartureDetailsHomeDto DepartureDetailsHome { get; set; }
        public virtual LandlordDetailsHomeDto LandlordDetailsHome { get; set; }
        public virtual RenewalDetailHomeDto RenewalDetailHome { get; set; }
        public virtual ICollection<AmenitiesHousingListDto> AmenitiesHousingLists { get; set; }
        public virtual ICollection<CostSavingHomeDto> CostSavingHomes { get; set; }
        public virtual ICollection<CommentHousingSelectDto> CommentHousings { get; set; }
        public virtual ICollection<DocumentHousingDto> DocumentHousings { get; set; }
        public virtual ICollection<HousingReportDto> HousingReports { get; set; }
        public virtual ICollection<HousingStatusHistoryDto> HousingStatusHistories { get; set; }
        public virtual ICollection<PaymentHousingDto> PaymentHousings { get; set; }
        public virtual ICollection<InspectionDto> Inspections { get; set; }
        public virtual ICollection<PropertyReportSelectDto> PropertyReports { get; set; }
        public virtual ICollection<RepairDto> Repairs { get; set; }
    }
}
