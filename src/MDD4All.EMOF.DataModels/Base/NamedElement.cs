using MDD4All.EMOF.DataModels.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class NamedElement : Element
    {
        [JsonProperty(Order = -100)]
        public string Name { get; set; } = string.Empty;

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(Order = -98)]
        public VisibilityKind Visibility { get; set; } = VisibilityKind.Public;

    }
}
