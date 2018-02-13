using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Avalonia.Android;
using Avalonia.Forms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly: ExportRenderer(typeof(AvaloniaFormsView), typeof(AvaloniaFormsViewRenderer))]
namespace Avalonia.Forms.Droid
{
    public class AvaloniaFormsViewRenderer : ViewRenderer<AvaloniaFormsView, AvaloniaView>
    {
        private AvaloniaView _view;

        public AvaloniaFormsViewRenderer()
        {
            Log.Debug("XAPPLOG", "Renderer created");
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AvaloniaFormsView> e)
        {
            Log.Debug("XAPPLOG", "ElementChanged");
            base.OnElementChanged(e);

            if (Control == null)
            {
                _view = new AvaloniaView(Context);
                SetNativeControl(_view);
            }

            if (e.OldElement != null)
            {
                _view.Content = null;
            }
            if (e.NewElement != null)
            {
                _view.Content = e.NewElement.Content;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Log.Debug("XAPPLOG", "Property " + e.PropertyName + " changed");
            if (e.PropertyName == "Content")
            {
                _view.Content = Element?.Content;
            }
            base.OnElementPropertyChanged(sender, e);
        }
    }
}