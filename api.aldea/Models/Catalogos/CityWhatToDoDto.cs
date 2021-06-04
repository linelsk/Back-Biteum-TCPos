﻿using System.Collections.Generic;

namespace api.premier.Models.Catalogue
{
    public class CityWhatToDoDto
    {
        public int Id { get; set; }
        public int IdCity { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PhotoWhatToDoDto> PhotoWhatToDos { get; set; }
    }
}