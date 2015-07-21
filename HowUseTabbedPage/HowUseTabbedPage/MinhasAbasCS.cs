using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HowUseTabbedPage
{
    public class MinhasAbasCS : TabbedPage
    {
        public MinhasAbasCS()
        {
            this.Title = "Como Usar Abas";

            this.Children.Add(new ContentPage()
            {
                Title = "1ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Primeira Aba"}
                  }
                }
            });
            this.Children.Add(new ContentPage()
            {
                Title = "2ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Segunda Aba"}
                  }
                }
            });
            this.Children.Add(new ContentPage()
            {
                Title = "3ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Terceira Aba"}
                  }
                }
            });
            this.Children.Add(new ContentPage()
            {
                Title = "4ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Quarta Aba"}
                  }
                }
            });
            this.Children.Add(new ContentPage()
            {
                Title = "5ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Quinta Aba"}
                  }
                }
            });
            this.Children.Add(new ContentPage()
            {
                Title = "6ª Aba",
                Icon = "icon.png",
                Content = new StackLayout()
                {
                    Children = {
                    new Label(){Text="Sexta Aba"}
                  }
                }
            });
        }
    }
}
