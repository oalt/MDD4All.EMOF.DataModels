namespace MDD4All.EMOF.DataModels.Base
{
    public interface IMultiplicityElement
    {
        bool IsOrdered { get; set; }

        bool IsUnique { get; set; }

        string Multiplicity { get; set; }
    }
}
