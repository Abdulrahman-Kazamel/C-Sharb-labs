using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meraki_API
{
  [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class my_data
    {
        [JsonProperty(PropertyName = "pass")]
        public string pass;
        [JsonProperty(PropertyName = "id")]
        public int id ;


    }
}
