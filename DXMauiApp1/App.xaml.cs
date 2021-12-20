using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using System;
using Application = Microsoft.Maui.Controls.Application;

namespace DXMauiApp1
{
    public partial class App : Application
    {
        private Microsoft.Maui.Controls.Page[] MainPages = { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null};
        public static App IDEAL;
        public App()
        {
            //InitializeComponent();
            MainPages[0] = new MainPage(); // ana sayfa
            MainPages[1] = new Page1(); // page1
            SetPage(1);
        }
        public void SetPage(int pagenum) {
            MainPage = MainPages[pagenum];
            IDEAL = this;
            
        }
    }
}
