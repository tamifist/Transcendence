﻿using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Foundation;

namespace TranscendenceChat.iOS
{
	[Register("NavigationControllerBase")]
	public class NavigationControllerBase : UINavigationController
	{
		public NavigationControllerBase (IntPtr handle)
			: base(handle)
		{
		}

		#region Life cycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			NavigationBar.Translucent = false;

			NavigationBar.SetBackgroundImage (new UIImage (), UIBarMetrics.Default);
			NavigationBar.ShadowImage = new UIImage ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			ApplyCurrentTheme ();
			Theme.ThemeChanged += OnThemeChanged;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Theme.ThemeChanged -= OnThemeChanged;
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		void OnThemeChanged (object sender, EventArgs e)
		{
			ApplyCurrentTheme();
		}

		void ApplyCurrentTheme()
		{
            // Set gradient color for the navigation bar's background
		    CGSize gradientImageSize = new CGSize(NavigationBar.Frame.Size.Width, NavigationBar.Frame.Size.Height + 20.0f);
		    UIImage gradientImage = ImageUtils.GetGradientImage(
                Theme.Current.MainGradientStartColor.CGColor, Theme.Current.MainGradientEndColor.CGColor, gradientImageSize);
            NavigationBar.BarTintColor = UIColor.FromPatternImage(gradientImage);
		}
	}
}

