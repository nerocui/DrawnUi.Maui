﻿namespace Sandbox.Views
{
    public partial class MainPageCarousels : ContentPage
    {

        public MainPageCarousels()
        {
            try
            {
                InitializeComponent();

                //avoid setting context BEFORE InitializeComponent, can bug 
                //having parent BindingContext still null when constructing from xaml
                BindingContext = new MainPageViewModel();
            }
            catch (Exception e)
            {
                Super.DisplayException(this, e);
                Console.WriteLine(e);
            }
        }

        private void SkiaButton_Tapped(object sender, AppoMobi.Maui.Gestures.TouchActionEventArgs e)
        {
            MainCarousel.ChildrenFactory.PrintDebugVisible();
        }
    }
}