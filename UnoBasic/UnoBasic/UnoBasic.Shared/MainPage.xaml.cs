using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoBasic
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}

		private void ChangeTextButton_Click(object sender, RoutedEventArgs e)
		{
			helloTextBlock.Text = "Hello, From Raden";

#if __ANDROID__ || __IOS__
			textVariasi.Text = "Hai, I'm C Sharp on MOBILE";
#elif HAS_UNO_WASM || __WASM__
			textVariasi.Text = "Hai, I'm C SHARP ON WEB (WASM)";
#else
			textVariasi.Text = "Just Hello";
#endif
		}
	}
}
