using MDD4All.EMOF.DataModels.DataTypes;
using MDD4All.EMOF.DataModels.Templates;
using Newtonsoft.Json;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class Classifier : Type, ITemplateableElement
    {
        [JsonProperty(Order = -98)]
        public bool IsAbstract { get; set; }

        [JsonProperty(Order = -95)]
        public TemplateSignature? OwnedTemplateSignature { get; set; }
    }
}
