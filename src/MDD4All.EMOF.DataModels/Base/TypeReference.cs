namespace MDD4All.EMOF.DataModels.Base
{
    public class TypeReference
    {
        public string FullName { get; set; } = string.Empty;

        public string? Version { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is TypeReference)
            {
                TypeReference other = (TypeReference)obj;
                result = FullName.Equals(other.FullName);
                if (Version != null)
                {
                    result = result && Version.Equals(other.Version);
                }
                else
                {
                    result = result && (other.Version == null);
                }
            }

            return result;
        }

        public override int GetHashCode()
        {
            int result = FullName.GetHashCode();

            if (Version != null)
            {
                result = result ^ Version.GetHashCode();
            }

            return result;
        }
    }
}
