using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_NavigationBar_MVVM_Practice.View {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page {
        public SettingsPage() {
            this.InitializeComponent();
        }

        private async void LightThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            // 라이트 테마로 변경
            ApplicationData.Current.LocalSettings.Values["AppTheme"] = "Light";
            await CoreApplication.RequestRestartAsync(string.Empty);
        }

        private async void DarkThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            // 다크 테마로 변경
            ApplicationData.Current.LocalSettings.Values["AppTheme"] = "Dark";
            await CoreApplication.RequestRestartAsync(string.Empty);
        }
    }
}
