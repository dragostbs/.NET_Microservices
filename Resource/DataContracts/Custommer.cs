using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Resource.DataContracts
{
    // DataContract used to transfer the data stored in Custommer from a micro service to another VFC, data becomes Objects
    [DataContract]
    public class Custommer
    {
        [DataMember]
        public Guid IDCustommer { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Resume { get; set; }
    }
}

