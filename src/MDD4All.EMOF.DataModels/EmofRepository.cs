using MDD4All.EMOF.DataModels.Base;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class EmofRepository
    {
        public List<Package> RootPackages { get; set; } = new List<Package>();

        [JsonIgnore]
        public Dictionary<Element, Dictionary<string, Tag>> Tags { get; set; } = new Dictionary<Element, Dictionary<string, Tag>>();
    }
}
