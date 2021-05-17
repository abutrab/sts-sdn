using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace sts_sdn
{
    public class Device
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime WarrantyYear { get; set; }
            
    }
}