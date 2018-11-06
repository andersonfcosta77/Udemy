using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
	{
		public Abas ()
		{
			InitializeComponent();
            //Na tabpage existe a apresentação da Página1 duas vezes, uma é realizada diretamente no XAML e outra carregada aqui via Código C#
            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina1()){Title = "Item3"});
		}
	}
}