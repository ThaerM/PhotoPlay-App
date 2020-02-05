using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using Plugin.Multilingual;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Helpers
{
    /// <summary>
    /// This class is specifically for a Xamarin Forms application usage
    /// </summary>

    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private const string ResourceId = "MoviesProject.Resource.AppResources";
        private static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));
        public string Text { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null) return "";
            var ci = CrossMultilingual.Current.CurrentCultureInfo;
            try
            {
                var translation = resmgr.Value.GetString(Text, ci);
                if (translation == null)
                    translation = Text;//Return the key, which GETS DISPLAY TO THE USER
                return translation;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" MoviesProject.Helpers=> " + ex.Message + " " + Text);
            }
            return "";
        }
    }
}
