﻿using System;
using Xamarin.Forms;

namespace WorkingWithPlatformSpecifics
{
	public class DevicePage : ContentPage
	{
		/// <summary>
		/// This page demonstrates the different ways to use the Device class
		/// to perform platform-specific operations like changing the UI
		/// based on which 
		/// </summary>
		public DevicePage()
		{
			var heading = new Label
			{
				Text = "Heading",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
			};

			switch (Device.Idiom)
			{
				case TargetIdiom.Phone:
					heading.Text += " Phone ";
					break;
				case TargetIdiom.Tablet:
					heading.Text += " Tablet ";
					break;
				case TargetIdiom.Desktop:
					heading.Text += " Desktop ";
					break;
				default:
					heading.Text += " unknown ";
					break;
			}

			if (Device.RuntimePlatform == Device.iOS)
			{
				heading.Text += "iOS";
			}
			else
			{
				heading.Text += Device.RuntimePlatform;
			}

			var timer = new Label
			{
				Text = "click start below"
			};

			double boxViewWidth;
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					boxViewWidth = 30;
					break;
				case Device.Android:
					boxViewWidth = 40;
					break;
				case Device.WinPhone:
				case Device.Windows:
				default:
					boxViewWidth = 50;
					break;
			}

			var box = new BoxView
			{
				Color = Color.Green,
				WidthRequest = boxViewWidth,
				HorizontalOptions = LayoutOptions.Center
			};

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					box.Color = box.Color.MultiplyAlpha(0.5);
					heading.TextColor = Color.Blue;
					break;
				case Device.Android:
					box.Color = box.Color.AddLuminosity(0.3);
					heading.TextColor = Color.FromRgb(115, 129, 130);
					break;
				case Device.WinPhone:
				case Device.Windows:
					box.Color = box.Color.AddLuminosity(0.3);
					heading.TextColor = Color.Accent;
					break;
				default:
					heading.Text = "what platform is this?!" + Device.RuntimePlatform;
					break;
			}

			//
			// Device.OnPlatform<T>
			//
			var timerButton = new Button
			{
				Text = "Start Timer",
				BackgroundColor = Color.Gray.MultiplyAlpha(0.5),
				HorizontalOptions = LayoutOptions.Center
			};

			double timerWidth;
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					timerWidth = 200;
					break;
				case Device.Android:
					timerWidth = 300;
					break;
				case Device.WinPhone:
				case Device.Windows:
				default:
					timerWidth = 100;
					break;
			}

			timerButton.WidthRequest = timerWidth;

			//
			// Device.StartTimer     and     Device.BeginInvokeOnMainThread
			//
			timerButton.Clicked += (sender, e) =>
			{
				timer.Text = "timer running...";
				Device.StartTimer(new TimeSpan(0, 0, 10), () =>
				{
					// do something every 10 seconds
					Device.BeginInvokeOnMainThread(() =>
					{
						// interact with UI elements
						timer.Text = DateTime.Now.ToString("mm:ss") + " past the hour";
					});

					return true; // runs again, or false to stop
				});
			};

			//
			// Device.OpenUri
			//
			var webButton = new Button
			{
				Text = "Open Uri"
			};
			webButton.Clicked += ((sender, e) => Device.OpenUri(new Uri("http://xamarin.com/evolve")));

			//
			// Device.OnPlatform<T>
			//
			double top;
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					top = 20;
					break;
				case Device.Android:
					top = 0;
					break;
				case Device.WinPhone:
				case Device.Windows:
				default:
					top = 0;
					break;
			}

			Content = new StackLayout
			{
				Padding = new Thickness(5, top, 5, 0),
				Children = {
					heading,
					box,
					webButton,
					timer,
					timerButton
				}
			};
		}
	}
}
