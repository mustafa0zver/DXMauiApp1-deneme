using DevExpress.Maui.DataGrid;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Essentials;
using System;
using System.Collections.ObjectModel;

namespace DXMauiApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e) {
            DXMauiApp1.App.IDEAL.SetPage(0);
        }
    }
}