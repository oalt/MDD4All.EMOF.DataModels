using MDD4All.DataModeling.Attributes;
using MDD4All.EMOF.DataModels.Base;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class Class : Classifier
    {
        [TypeReferenceTo(typeof(Classifier))]
        public List<TypeReference>? SuperClassRefs { get; set; }

        public List<Property> OwnedAttributes { get; set; } = new List<Property>();
    }
}
