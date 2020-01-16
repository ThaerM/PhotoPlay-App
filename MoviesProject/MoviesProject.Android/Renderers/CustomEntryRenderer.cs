using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MoviesProject.Controls;
using MoviesProject.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MoviesProject.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                try
                {
                    //Remove the background from entry
                    Control.Background = null;
                    //Change the text color
                    Control.SetTextColor(Android.Graphics.Color.White);

                    IntPtr InptrTextViewClass = JNIEnv.FindClass(typeof(TextView));
                    IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(InptrTextViewClass, "mCursorDrawableRes", "I");

                    //.. m_cursor is the xml file name which we defined above
                    JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, Resource.Drawable.EntryController);
                }
                catch (Exception ex)
                {
                    Log.Debug("Entry", "CustomEntryRenderer.OnElementChanged " + ex.Message);
                }
            }
        }

    }
}