using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace sts_sdn
{
    public class SimcardModel
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Number { get; set; }
         private protected enum Provider { Zain,Batelco}

    }
}