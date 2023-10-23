namespace System.ComponentModel.DataAnnotations
{
    internal class AllowedExtensionsAttribute : Attribute
    {
        private string[] allowedExtensions;

        public AllowedExtensionsAttribute(string[] allowedExtensions)
        {
            this.allowedExtensions = allowedExtensions;
        }
    }
}