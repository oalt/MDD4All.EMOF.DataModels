using MDD4All.EMOF.DataModels.DataTypes;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class Enumeration : DataType
    {
        public List<EnumerationLiteral> OwnedLiterals { get; set; } = new List<EnumerationLiteral>();
    }
}
