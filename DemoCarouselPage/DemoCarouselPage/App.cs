using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoCarouselPage
{
    public class App : Application
    {
        public App()
        {

            //StackLayout sLFirst = new StackLayout()
            //{
            //    Orientation = StackOrientation.Vertical,
            //    BackgroundColor = Color.Blue,
            //    Children =
            //    {
            //        new Label{Text = "Primeira Página", FontSize=15, TextColor = Color.White, VerticalOptions = LayoutOptions.CenterAndExpand, XAlign = TextAlignment.Center},
            //        new Label{Text = @"Você pode realizar formulários/guias informando passo a passo utilizando a CarouselPage", FontSize=13, TextColor= Color.White, XAlign = TextAlignment.Center},
            //        new Label{Text = "Página 1 de 3", VerticalOptions = LayoutOptions.EndAndExpand,
            //        FontSize = 12, TextColor = Color.White, XAlign = TextAlignment.Center}

            //    }
            //};

            //StackLayout sLSecond = new StackLayout()
            //{
            //    Orientation = StackOrientation.Vertical,
            //    BackgroundColor = Color.Red,
            //    Children =
            //    {
            //        new Label{Text = "Segunda Página", FontSize=15, TextColor = Color.White, VerticalOptions = LayoutOptions.CenterAndExpand, XAlign = TextAlignment.Center},
            //        new Label{Text = "Segundo passo do guia! Veja como é facil utilizar a CarouselPage", FontSize=13, TextColor= Color.White, XAlign = TextAlignment.Center},
            //        new Label{Text = "Página 2 de 3", VerticalOptions = LayoutOptions.EndAndExpand,
            //        FontSize = 12, TextColor = Color.White, XAlign = TextAlignment.Center}

            //    }
            //};

            //StackLayout sLThird = new StackLayout()
            //{
            //    Orientation = StackOrientation.Vertical,
            //    BackgroundColor = Color.Black,
            //    Children =
            //    {
            //        new Label{Text = "Terceira Página", FontSize=15, TextColor = Color.White, VerticalOptions = LayoutOptions.CenterAndExpand, XAlign = TextAlignment.Center},
            //        new Label{Text = "Fim do nosso guia/formulário", FontSize=13, TextColor= Color.White, VerticalOptions = LayoutOptions.CenterAndExpand, 
            //            XAlign = TextAlignment.Center},
            //        new Label{Text = "Página 3 de 3", VerticalOptions = LayoutOptions.EndAndExpand,
            //        FontSize = 12, TextColor = Color.White, XAlign = TextAlignment.Center}
            //    }
            //};

            //// The root page of your application 
            //MainPage = new CarouselPage
            //{
            //    Children =
            //    {
            //        new ContentPage{Content = sLFirst},
            //        new ContentPage{Content = sLSecond},
            //        new ContentPage{Content = sLThird}
            //    }
            //};

            MainPage = new CarouselMainPage();
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
