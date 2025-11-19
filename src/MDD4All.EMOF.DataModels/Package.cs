using MDD4All.EMOF.DataModels.Base;
using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels
{
    public class Package : PackageableElement
    {
        public string? URI { get; set; }

        public List<Package> NestedPackages { get; set; } = new List<Package>();

        public List<PackageableElement> PackagedElements { get; set; } = new List<PackageableElement>();

        public override string ToString()
        {
            return "[Package] " + Name;
        }
    }
}
