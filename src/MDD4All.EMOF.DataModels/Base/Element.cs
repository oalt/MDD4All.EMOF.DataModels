using MDD4All.EMOF.DataModels.Annotations;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class Element : IAnnotatableElement
    {
        public List<InstanceSpecification>? Annotations { get; set; }
    }
}
