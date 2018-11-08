using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_LayoutsXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void GoPagniaStack(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }

        private void GoPagniaGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        private void GoPagniaAbsolut(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Absolut.AbsolutePage());
        }

        private void GoPagniaRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        private void GoPagniaScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
