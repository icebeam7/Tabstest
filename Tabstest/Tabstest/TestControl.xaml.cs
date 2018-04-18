using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabstest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestControl : ContentPage
	{
		public TestControl ()
		{
			InitializeComponent ();
		}
	}
}