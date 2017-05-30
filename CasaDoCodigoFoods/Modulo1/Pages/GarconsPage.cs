using System;

using Xamarin.Forms;

namespace Modulo1
{
	public class GarconsPage : TabbedPage
	{
		public GarconsPage()
		{
			Title = "Garçons";
			Children.Add(new GarconsListPage()
			{
				Title = "Listagem",
				Icon = "icone_list.png"
			});
			Children.Add(new GarconsNewPage()
			{
				Title = "Inserir novo",
				Icon = "icone_new.png"
			});
		}
	}
}