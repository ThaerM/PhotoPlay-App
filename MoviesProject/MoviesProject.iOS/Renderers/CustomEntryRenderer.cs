using System.ComponentModel;
using MoviesProject.Controls;
using MoviesProject.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MoviesProject.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control != null)
            {
                //Change the border width to zero
                Control.Layer.BorderWidth = 0;
                //Stop the style of border
                Control.BorderStyle = UITextBorderStyle.None;
                //Change the color of text
                Control.TextColor = UIColor.White;
                //Chnage the color of the tint
                Control.TintColor = UIColor.White;
            }
        }
    }
}