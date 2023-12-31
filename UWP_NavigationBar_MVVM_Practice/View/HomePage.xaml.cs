﻿using UWP_NavigationBar_MVVM_Practice.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_NavigationBar_MVVM_Practice.View {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public HomePage() {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }
    }
}
