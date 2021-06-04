using api.premier.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.Catalogue
{
    public class CatCityDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int IdCountry { get; set; }
        public int? IdTimeZone { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<CityAboutDto> CityAbouts { get; set; }
        public virtual ICollection<CityAttractionDto> CityAttractions { get; set; }
        public virtual ICollection<CityEmergencyDto> CityEmergencies { get; set; }
        public virtual ICollection<CityWhatToDoDto> CityWhatToDos { get; set; }
        public virtual ICollection<CityWhereEatDto> CityWhereEats { get; set; }
    }
}
