using MDD4All.EMOF.DataModels.Base;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class Interface : Classifier
    {
        public List<string>? RedefinedInterfacesRef { get; set; }

        public List<Property> OwnedAttributes { get; set; } = new List<Property>();
    }
}
