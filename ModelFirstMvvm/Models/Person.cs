using System.ComponentModel;

namespace Models
{
    public class Person : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
