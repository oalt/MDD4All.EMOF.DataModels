using Newtonsoft.Json;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class PackageableElement : NamedElement
    {
        [JsonIgnore]
        public Package? OwningPackage { get; set; }

        [JsonProperty(Order = -97)]
        public string Namespace
        {
            get
            {
                string result = "";

                if (OwningPackage != null)
                {
                    Package? currentPackage = OwningPackage;

                    while (currentPackage != null)
                    {
                        result = currentPackage.Name + "." + result;
                        currentPackage = currentPackage.OwningPackage;
                    }

                    if (result.EndsWith("."))
                    {
                        result = result.Substring(0, result.Length - 1);
                    }
                }

                return result;
            }
        }

        [JsonProperty(Order = -96)]
        public string FullName
        {
            get
            {
                string result = Namespace;

                if(!string.IsNullOrEmpty(result))
                {
                    result += ".";
                }

                result += Name;

                return result;
            }
        }
    }
}
