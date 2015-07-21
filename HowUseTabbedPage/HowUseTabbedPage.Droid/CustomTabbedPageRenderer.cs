using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using HowUseTabbedPage.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace HowUseTabbedPage.Droid
{
    public class CustomTabbedPageRenderer : TabbedRenderer
    {

        protected override void DispatchDraw(Android.Graphics.Canvas canvas)
        {
            setIcons();
            base.DispatchDraw(canvas);
        }

        private void setIcons()
        {
            //Responsável pela Tela
            var Activity = this.Context as Activity;

            if (Activity != null && Activity.ActionBar != null)
            {
                int i = 0;

                foreach (var item in this.Element.Children)
                {

                    Android.App.ActionBar.Tab Aba = Activity.ActionBar.GetTabAt(i);

                    Aba.SetIcon(ResourceIdFromString(item.Icon.File));


                    i++;
                }
            }
        }

        private int ResourceIdFromString(string p)
        {
			p = p.ToLower ().Replace (".png", "").Replace (".jpg", "");

            Type tipo = typeof(Resource.Drawable);

            return (int)tipo.GetFields().FirstOrDefault(n => n.Name.ToLower() == p).GetValue(null);
        }

    }
}