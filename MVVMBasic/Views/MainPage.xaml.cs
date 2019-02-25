﻿using System;

using MVVMBasic.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMBasic.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
