using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels.Annotations
{
    public interface IAnnotatableElement
    {
        List<InstanceSpecification>? Annotations { get; set; }
    }
}
