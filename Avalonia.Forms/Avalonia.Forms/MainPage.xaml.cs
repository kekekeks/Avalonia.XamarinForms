using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCatalog;
using Xamarin.Forms;

namespace Avalonia.Forms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    AvaloniaView.Content = new MainView();
		}
	}
}
