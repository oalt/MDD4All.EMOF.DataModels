namespace MDD4All.EMOF.DataModels.Base
{
    public abstract class TypedElement : NamedElement
    {
        private string? _typeAsString = null;

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
