using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace Avalonia.Forms.Droid
{
	[Activity (Label = "Avalonia.Forms", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            Log.Debug("APP", "OnCreate");
            base.OnCreate(bundle);

            

            Avalonia.AppBuilder.Configure<ControlCatalog.App>().UseAndroid().UseSkia().SetupWithoutStarting();

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Avalonia.Forms.App ());
		}
	}
}

