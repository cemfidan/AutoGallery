﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGallery.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
