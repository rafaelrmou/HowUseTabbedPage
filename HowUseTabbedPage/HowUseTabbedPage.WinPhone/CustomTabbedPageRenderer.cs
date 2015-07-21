using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using HowUseTabbedPage.WinPhone;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace HowUseTabbedPage.WinPhone
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

        }

    }
}