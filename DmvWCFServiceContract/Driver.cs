using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DmvWCFServiceContract
{
    [DataContract]
    public class Driver
    {
        [DataMember]
        public string Name { get;  set; }
        [DataMember]
        public string DOB { get; set; }
        [DataMember]
        public string LicenseNo { get; set; }
        [DataMember]
        public string LicenseState { get; set; }

    }
}
