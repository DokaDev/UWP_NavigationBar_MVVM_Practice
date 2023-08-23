using Windows.UI.Xaml.Controls;
using UWP_NavigationBar_MVVM_Practice.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_NavigationBar_MVVM_Practice {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            if (args.IsSettingsInvoked) {
                ContentFrame.Navigate(typeof(SettingsPage));
                return;
            }

            var tag = args.InvokedItemContainer.Tag.ToString();
            switch(tag) {
                case "Home_Page":
                    ContentFrame.Navigate(typeof(View.HomePage));
                    break;
            }
        }
    }
}
