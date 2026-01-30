using MDD4All.EMOF.DataModels.Base;

namespace MDD4All.EMOF.DataModels
{
    public class Slot : Element
    {
        public string DefiningFeatureRef { get; set; } = string.Empty;

        public string? Value { get; set; }
    }
}
