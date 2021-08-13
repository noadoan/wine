using System;
using System.Collections.Generic;

namespace DTO
{
    public class ProductDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> YearProduction { get; set; }
        public string Description { get; set; }
        public Nullable<int> WineId { get; set; }
        public Nullable<int> ProductTypeId { get; set; }
        public Nullable<int> TasteId { get; set; }
        public Nullable<double> PercentageAlcohol { get; set; }
    }
}