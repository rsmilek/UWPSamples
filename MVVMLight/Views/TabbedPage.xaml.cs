using System;

using MVVMLight.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMLight.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel
        {
            get { return ViewModelLocator.Current.TabbedViewModel; }
        }

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
