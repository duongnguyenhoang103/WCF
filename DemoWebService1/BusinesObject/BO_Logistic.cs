using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace BusinesObject
{
    [DataContract ]
  public class BO_Logistic
    {
       [DataMember]
        public string TrnspCode { get; set; }

       [DataMember]
        public string ShipToCode { get; set; }

       [DataMember]
        public string PayToCode { get; set; }

       [DataMember]      
        public string Confirmed { get; set; }
    }
}
