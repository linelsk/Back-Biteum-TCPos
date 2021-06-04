using api.premier.Models.Catalogue;

namespace api.premier.Models.ClientPartnerProfile
{
    public class OfficeContactDto
    {
        public int Id { get; set; }
        public int IdOfficeInformation { get; set; }
        public int IdContactType { get; set; }
        public string ContactName { get; set; }
        public string Tittle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int IdCity { get; set; }

        public virtual CatCityDto IdCityNavigation { get; set; }
        public virtual OfficeContactTypeDto IdContactTypeNavigation { get; set; }
        public virtual OfficeInformationDto IdOfficeInformationNavigation { get; set; }
    }
}