using MDD4All.DataModeling.Attributes;
using MDD4All.EMOF.DataModels.DataTypes;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class TypedElement : NamedElement
    {
        [TypeReferenceTo(typeof(Type))]
        public TypeReference TypeRef { get; set; } = new TypeReference();

        [TypeReferenceTo(typeof(Type))]
        public TypeReference? CollectionTypeRef { get; set; }
    }
}
