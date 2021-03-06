﻿using System;
using UIKit;

namespace TranscendenceChat.iOS
{
	public class RedColorTheme : IColorTheme
	{
		public static RedColorTheme Instance { get; private set; }

		private RedColorTheme()
		{
		}

		static RedColorTheme()
		{
			Instance = new RedColorTheme();
		}

		public UIStatusBarStyle StatusBarStyle {
			get {
				return UIStatusBarStyle.LightContent;
			}
		}

		public UIColor ScreenTitleColor {
			get {
				return UIColor.White;
			}
		}

        public UIColor MainGradientStartColor
        {
            get
            {
                return UIColor.FromRGB(228, 37, 41);
            }
        }

        public UIColor MainGradientEndColor
        {
            get
            {
                return UIColor.FromRGB(148, 46, 135);
            }
        }

        public UIColor MainSaturatedColor {
			get {
				return AppColors.FromHex (0xED21A4);
			}
		}

		public UIColor DisabledButtonColor {
			get {
				return AppColors.FromHex(0xD3D3D3);
			}
		}

		public UIColor NavigationBarButtonColor {
			get {
				return AppColors.FromHex (0x000000);
			}
		}

		public UIColor TitleTextColor {
			get {
				return AppColors.FromHex (0x000000).ColorWithAlpha(0.8f);
			}
		}

		public UIColor DescriptionDimmedColor {
			get {
				return AppColors.FromHex (0x000000).ColorWithAlpha (0.5f);
			}
		}

		public UIColor BackgroundColor {
			get {
				return AppColors.FromHex (0xF9F9F9);
			}
		}

		#region Conversations screen

		public UIColor FriendNameColor {
			get {
				return AppColors.FromHex (0x000000).ColorWithAlpha(0.8f);
			}
		}

		public UIColor LastMessageTextColor {
			get {
				return AppColors.FromHex (0x000000).ColorWithAlpha(0.5f);
			}
		}

		public UIColor DateMessageLabelColor {
			get {
				return AppColors.FromHex (0x000000).ColorWithAlpha(0.5f);
			}
		}

		public UIColor ConversationSelectedCellColor {
			get {
				return MainGradientStartColor;
			}
		}

		#endregion

		#region Conversation with Friend screen

		public UIColor IncomingBubbleStroke {
			get {
				return AppColors.FromHex (0xD9D9D9);
			}
		}

		public UIColor IncomingTextColor {
			get {
				return AppColors.FromHex(0x000000).ColorWithAlpha (0.5f);
			}
		}

		public UIColor OutgoingTextColor {
			get {
				return UIColor.White;
			}
		}

		public UIColor OutgoingBubbleColor {
			get {
				return UIColor.FromRGB(34, 151, 253);//#2297fd
            }
		}

		#endregion

		#region Points

		public UIColor BadgeTitleColor {
			get {
				return AppColors.FromHex (0x929292);
			}
		}

		#endregion
	}
}

