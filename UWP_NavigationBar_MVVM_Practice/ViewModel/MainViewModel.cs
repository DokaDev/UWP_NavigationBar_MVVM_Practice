using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using UWP_NavigationBar_MVVM_Practice.Model;

namespace UWP_NavigationBar_MVVM_Practice.ViewModel {
    public class MainViewModel : ViewModelBase {
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People {
            get => _people;
            set => Set(ref _people, value);
        }

        public MainViewModel() {
            People = new ObservableCollection<Person> {
                new Person() { Name = "Alice", Age = 30},
                new Person() { Name = "Bob", Age = 25},
            };
        }
    }
}
