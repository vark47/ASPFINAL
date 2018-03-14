using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstateFinal.Models;


namespace RealEstateFinal.Models
{
    public class Listing
    {

        // public int ImageID { get; set; }
        public int ID { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public decimal Rent { get; set; }
        public string ImgURL { get; set; } //I chose to include this as a property instead of a foreign key because the schema made more sense
        public int Beds { get; set; }
        public double Baths { get; set; } // set as double due to half baths
        public bool AvailableNow { get; set; } 


    }
}
