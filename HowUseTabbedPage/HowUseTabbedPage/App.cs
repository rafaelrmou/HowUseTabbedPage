using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HowUseTabbedPage
{
    public class App : Application
    {
        public App()
        {
            var btnCs = new Button()
            {
                Text = "Abas Code Only"
            };
            btnCs.Clicked += btnCs_Clicked;

            var btnXaml = new Button()
            {
                Text = "Abas XAML"
            };
            btnXaml.Clicked += btnXaml_Clicked;

            // The root page of your application
            MainPage = new NavigationPage(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Abra uma das Telas"
						},
                        btnCs,
                        btnXaml
					}
                }
            });
        }

        void btnXaml_Clicked(object sender, EventArgs e)
        {
            MainPage.Navigation.PushAsync(new MinhasAbasXaml());
        }

        void btnCs_Clicked(object sender, EventArgs e)
        {
            MainPage.Navigation.PushAsync(new MinhasAbasCS());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
