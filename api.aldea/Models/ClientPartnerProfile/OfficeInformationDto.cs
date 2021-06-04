using api.premier.Models.Catalogos;
using api.premier.Models.Catalogue;
using System.Collections.Generic;

namespace api.premier.Models.ClientPartnerProfile
{
    public class OfficeInformationDto
    {
        public int Id { get; set; }
        public int IdClientPartnerProfile { get; set; }
        public int IdTypeOffice { get; set; }
        public string CommercialName { get; set; }
        public string LegalName { get; set; }
        public int IdCountry { get; set; }
        public int IdCity { get; set; }
        public string CurrentAddress { get; set; }
        public int ZipCode { get; set; }

        public virtual CatCityDto IdCityNavigation { get; set; }
        //public virtual ClientPartnerProfileDto IdClientPartnerProfileNavigation { get; set; }
        public virtual CatCountryDto IdCountryNavigation { get; set; }
        public virtual ICollection<PaymentInformationOfficeDto> PaymentInformationOffices { get; set; }
        public virtual TypeOfficeDto IdTypeOfficeNavigation { get; set; }
        public virtual ICollection<DocumentOfficeInformationDto> DocumentOfficeInformations { get; set; }
        public virtual ICollection<OfficeContactDto> OfficeContacts { get; set; }
    }
}