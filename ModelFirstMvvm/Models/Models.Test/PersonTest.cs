using FluentAssertions;
using Xunit;

namespace Models.Test
{
    public class PersonTest
    {
        [Fact]
        public void Constructor_SetsProperties()
        {
            var firstName = "First";
            var lastName = "Last";

            var person = new Person(firstName, lastName);

            person.FirstName.Should().Be(firstName);
            person.LastName.Should().Be(lastName);
        }

        [Fact]
        public void FirstName_PropertyChangedFired()
        {
            var wasChanged = false;
            var person = new Person("First", "Last");

            person.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == nameof(person.FirstName))
                {
                    wasChanged = true;
                }
            };
            person.FirstName = "New";

            wasChanged.Should().BeTrue();
        }
    }
}
