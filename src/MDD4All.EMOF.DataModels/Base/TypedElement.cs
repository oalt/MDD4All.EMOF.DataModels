using MDD4All.EMOF.DataModels.DataTypes;
using Newtonsoft.Json;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class TypedElement : NamedElement
    {
        [JsonIgnore]
        public Type? Type { get; set; }
    
        public string TypeRef
        {
            get
            {
                string result = "";
                if (Type != null)
                {
                    result = Type.FullName;
                }
                return result;
            }
        }
    }
}
