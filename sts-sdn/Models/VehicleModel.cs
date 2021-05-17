using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace sts_sdn.Models
{
    public class VehicleModel
    {
        public int Id  { get; set; }
        public string Alias { get; set; }
        public string PlateNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        private enum Type { Light, Heavy }

    }

   
}