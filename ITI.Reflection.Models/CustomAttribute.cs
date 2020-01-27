
namespace Models
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Method
    | System.AttributeTargets.Parameter | System.AttributeTargets.Property)]
    public class CustomAttribute : System.Attribute
    {
        private string info;
        public CustomAttribute(string info)
        {
            this.info = info;
        }
    }
}
