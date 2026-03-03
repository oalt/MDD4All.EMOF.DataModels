using MDD4All.DataModeling.Attributes;
using MDD4All.EMOF.DataModels.DataTypes;

namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class TypedElement : NamedElement
    {
        private string? _typeAsString = null;

        [TypeReferenceTo(typeof(Type))]
        public string TypeRef
        {
            get
            {
                string result = "";
                if (_typeAsString != null)
                {
                    result = _typeAsString;
                }
                
                return result;
            }

            set
            {
                _typeAsString = value;
            }
        }

        private string? _collectionTypeRef = null;

        [TypeReferenceTo(typeof(Type))]
        public string? CollectionTypeRef
        {
            get
            {
                string? result = null;
                if (_collectionTypeRef != null)
                {
                    result = _collectionTypeRef;
                }

                return result;
            }

            set
            {
                _collectionTypeRef = value;
            }
        }


    }
}
