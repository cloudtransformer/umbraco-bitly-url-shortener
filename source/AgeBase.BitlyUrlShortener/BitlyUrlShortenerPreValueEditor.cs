using Umbraco.Core.PropertyEditors;

namespace AgeBase.BitlyUrlShortener
{
    internal class BitlyUrlShortenerPreValueEditor : PreValueEditor
    {
        public BitlyUrlShortenerPreValueEditor()
        {
            Fields.Add(new PreValueField
            {
                Description = "This is the Bit.ly Login",
                Key = "login",
                View = "requiredfield",
                Name = "Login"
            });

            Fields.Add(new PreValueField
            {
                Description = "This is the Bit.ly API Key",
                Key = "apiKey",
                View = "requiredfield",
                Name = "API Key"
            });
        }
    }
}