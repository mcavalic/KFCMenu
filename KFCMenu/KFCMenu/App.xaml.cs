using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFCMenu
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental", "Brush_Experimental", "Expander_Experimental" });
            InitializeComponent();

            MainPage = new Pocetna();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
