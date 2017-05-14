using System;

using Xamarin.Forms;

namespace MaratonaXamarin.iOS
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

