using System;

using Xamarin.Forms;

namespace Modulo1
{
	public class MenuDeOpcoes : ContentPage
	{
		public MenuDeOpcoes()
		{
			Title = "Menu de opções";
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Button() {
						Text = "Garçons",
						Image = "icone_garcons.png",
						Command = new Command(() => Navigation.PushAsync(new GarconsPage()))
					}
				}
			};
		}
	}
}