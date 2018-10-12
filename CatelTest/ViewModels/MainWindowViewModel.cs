using System;
using System.Collections.ObjectModel;
using CatelTest.Models;

namespace CatelTest.ViewModels
{
    using Catel.MVVM;

    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Person> Persons { get; set; }
        public Person SelectedPerson { get; set; }
        public Command RemovePersonCommand { get; set; }
        public MainWindowViewModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person
            {
                BirthDate = DateTime.Today,
                Name =  "1324134"
            });
            RemovePersonCommand = new Command(() => Persons.Remove(SelectedPerson), () => SelectedPerson != null);
        }

        public override string Title { get { return "CatelTest"; } }
    }
}
