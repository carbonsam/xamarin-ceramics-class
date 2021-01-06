using Models;

namespace ViewModels
{
    public class PersonViewModel
    {
        private readonly Person person;

        public PersonViewModel(Person person)
        {
            this.person = person;
        }

        public string FirstName
        {
            get => person.FirstName;
            set => person.FirstName = value;
        }

        public string LastName
        {
            get => person.LastName;
            set => person.LastName = value;
        }

        public string Greeting => $"Howdy {FirstName} {LastName}!";
    }
}
