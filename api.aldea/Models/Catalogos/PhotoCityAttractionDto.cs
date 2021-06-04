﻿using System;

namespace api.premier.Models.Catalogue
{
    public class PhotoCityAttractionDto
    {
        public int Id { get; set; }
        public int IdAttractionAbout { get; set; }
        public string FileName { get; set; }
        public string FileExtencion { get; set; }
        public string FileRequest { get; set; }
        public DateTime CreateDate { get; set; }
    }
}