using MDD4All.EMOF.DataModels.Base;

namespace MDD4All.EMOF.DataModels
{
    public class Tag : Element
    {
        public string Name { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;
    }
}
