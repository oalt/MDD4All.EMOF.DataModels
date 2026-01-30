using MDD4All.EMOF.DataModels.Base;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class InstanceSpecification : PackageableElement
    {
        public string? ClassifierRef { get; set; }

        public List<Slot>? Slots { get; set; }
    }
}
