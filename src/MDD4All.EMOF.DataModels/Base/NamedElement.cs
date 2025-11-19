using MDD4All.EMOF.DataModels.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class NamedElement : Element
    {
        [JsonProperty(Order = -100)]
        public string Name { get; set; } = string.Empty;

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(Order = -99)]
        public VisibilityKind Visibility { get; set; } = VisibilityKind.Public;

    }
}
