using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class StructuralFeature : TypedElement, IMultiplicityElement
    {
        public bool IsReadOnly { get; set; } = false;

        public bool IsOrdered { get; set; }

        public bool IsUnique { get; set; }

        public string Multiplicity { get; set; } = "1";
    }
}
