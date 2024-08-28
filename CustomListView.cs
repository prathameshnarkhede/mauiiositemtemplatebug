// CustomListView.cs
using System.Collections;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class CustomListView : TemplatedView
    {
        public static readonly BindableProperty ItemTemplateProperty =
            BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(CustomListView), null, propertyChanged: OnItemTemplateChanged);

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(CustomListView), null, propertyChanged: OnItemsSourceChanged);

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        private static void OnItemTemplateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomListView)bindable;
            control.UpdateListView();
        }

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomListView)bindable;
            control.UpdateListView();
        }

        private void UpdateListView()
        {
            var listView = (ListView)GetTemplateChild("PresentingView");
            if (listView != null)
            {
                listView.ItemTemplate = ItemTemplate;
                listView.ItemsSource = ItemsSource;
            }
        }
    }
}