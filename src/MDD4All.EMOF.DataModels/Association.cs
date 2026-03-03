using MDD4All.EMOF.DataModels.Base;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class Association : Classifier, IRelationship
    {
        public List<Property> OwnedEnds { get; set; } = new List<Property>();
    }
}
