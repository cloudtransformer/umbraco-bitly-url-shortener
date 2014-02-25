using ClientDependency.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace AgeBase.BitlyUrlShortener
{
    [PropertyEditor("AgeBase.BitlyUrlShortener", "AgeBase: Bitly Url Shortener", "/App_Plugins/AgeBase.BitlyUrlShortener/Resource/Editor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "/App_Plugins/AgeBase.BitlyUrlShortener/Resource/Controller.js")]
    public class BitlyUrlShortenerPropertyEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new BitlyUrlShortenerPreValueEditor();
        }
    }
}