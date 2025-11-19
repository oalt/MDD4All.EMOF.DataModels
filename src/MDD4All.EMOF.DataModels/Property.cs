using MDD4All.EMOF.DataModels.Base;
using MDD4All.EMOF.DataModels.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MDD4All.EMOF.DataModels
{
    public class Property : StructuralFeature
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PropertyKind Kind { get; set; } = PropertyKind.Property;
    }
}
