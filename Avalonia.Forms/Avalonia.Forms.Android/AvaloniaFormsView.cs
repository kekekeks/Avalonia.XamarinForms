using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Avalonia.Forms.Droid
{
    public class AvaloniaFormsView : View
    {
        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(AvaloniaFormsView));

        public AvaloniaFormsView()
        {
            
        }

        public object Content
        {
            get { return GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
    }
}