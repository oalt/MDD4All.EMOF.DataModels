using System.Collections.Generic;

namespace MDD4All.EMOF.DataModels.Templates
{
    public class TemplateSignature
    {
        public List<TemplateParameter> OwnedParameters { get; set; } = new List<TemplateParameter>();
    }
}
