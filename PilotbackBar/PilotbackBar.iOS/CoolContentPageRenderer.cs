using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using PilotbackBar;
using PilotbackBar.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CoolContentPage), typeof(CoolContentPageRenderer))]
namespace PilotbackBar.iOS
{
    public class CoolContentPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

           // SetCustomBackButton();
        }

        private void SetCustomBackButton()
        {
            var backBtnImage = UIImage.FromBundle("iosbackarrow.png");

            backBtnImage = backBtnImage.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);

            var backButtonItemWithImage = new UIBarButtonItem(backBtnImage, UIBarButtonItemStyle.Plain, BtnClick)
            {
                ImageInsets = new UIEdgeInsets(0f, -8f, 0f, 0f)
            };

            UIBarButtonItem[] bArray = { backButtonItemWithImage };

            NavigationController.TopViewController.NavigationItem.SetLeftBarButtonItems(bArray,false);
        }

        private void BtnClick(object sender, EventArgs e)
        {
            if (((CoolContentPage)Element)?.CustomBackButtonAction != null)
            {
                ((CoolContentPage)Element)?.CustomBackButtonAction.Invoke();
            }
            else App.Current.MainPage.Navigation.PopAsync();
        }
    }
}