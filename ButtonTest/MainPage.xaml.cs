using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace ButtonTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		int count = 0;
		private async void OnCounterClicked(object sender, EventArgs e)
		{
			await FilePicker.PickAsync();
			count++;
			CounterLabel.Text = $"Current count: {count}";
		}
	}
}
