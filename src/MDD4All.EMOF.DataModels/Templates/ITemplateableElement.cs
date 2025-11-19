namespace MDD4All.EMOF.DataModels.Templates
{
    public interface ITemplateableElement
    {
        TemplateSignature? OwnedTemplateSignature { get; set; }

        //bool IsTemplate { get; }
    }
}
