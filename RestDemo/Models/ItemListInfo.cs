using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestDemo.Models
{
    [DataContract]
    public class ItemListInfo
    {

        [DataMember(Name = "itemName")]
        public string itemName { get; set; }

        [DataMember(Name = "itemKind")]
        public float itemKind { get; set; }

        [DataMember(Name = "itemValue")]
        public DateTime itemValue { get; set; }

    }
}