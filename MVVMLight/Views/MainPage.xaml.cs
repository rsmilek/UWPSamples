﻿using System;

using MVVMLight.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMLight.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
