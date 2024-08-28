using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            MyCustomListView.ItemsSource = new List<Item>
                                            {
                                                new("Item 1" ),
                                                new("Item 2" ),
                                                new("Item 3" ),
                                            };
        }

        private void Blue_Foreground_Clicked(object sender, EventArgs e)
        {
            MyCustomListView.ItemTemplate = (DataTemplate)Resources["ItemTemplateOne"];
        }

        private void Red_Foreground_Clicked(object sender, EventArgs e)
        {
            MyCustomListView.ItemTemplate = (DataTemplate)Resources["ItemTemplateTwo"];
        }
    }
}