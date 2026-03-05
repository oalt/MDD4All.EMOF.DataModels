using MDD4All.EMOF.DataModels.Annotations;
using MDD4All.EMOF.DataModels.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class Element : IAnnotatableElement, IVersionable
    {
        [JsonProperty(Order = -99)]
        public string? Version { get; set; }

        public List<InstanceSpecification>? Annotations { get; set; }
    }
}
