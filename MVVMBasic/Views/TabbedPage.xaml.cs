using System;

using MVVMBasic.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMBasic.Views
{
    public sealed partial class TabbedPage : Page
    {
        public TabbedViewModel ViewModel { get; } = new TabbedViewModel();

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
