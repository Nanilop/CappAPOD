using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace appTestJSON
{
    [DataContract]
    public class DataSerie
    {
        [DataMember(Name = "copyright")]
        public string copyright { get; set; }

        [DataMember(Name = "Date")]
        public string Date { get; set; }
        [DataMember(Name = "explanation")]
        public string explanation { get; set; }

        [DataMember(Name = "hdurl")]
        public string hdurl { get; set; }

        [DataMember(Name = "title")]
        public string title { get; set; }

        [DataMember(Name = "media_type")]
        public string media_type { get; set; }
        [DataMember(Name = "service_version")]
        public string service_version { get; set; }

        [DataMember(Name = "url")]
        public string url { get; set; }
        public override string ToString() {
            return title;
                }
    }

}
