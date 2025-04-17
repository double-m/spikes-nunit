using System.Text.Json;
using System.Text.Json.Nodes;
using NUnit.Framework;
using PersonServices;

namespace PersonServices.UnitTests.Services
{
    [TestFixture]
    public class PersonService_GetSerializedPersonsShould
    {
        private PersonService _personService;

        [SetUp]
        public void SetUp()
        {
            _personService = new PersonService();
        }

        [Test]
        public void GetSerializedPerson_ReturnSerializedObjects()
        {
            var expected = JsonSerializer.Serialize<List<Object>>(
            [
                new {
                    FirstName = "Alessio",
                    LastName = "Rossi",
                    Age = 30
                },
                new {
                    FirstName = "Barbara",
                    LastName = "Verdi",
                    Age = 30
                }
            ]);

            var personJsonString = _personService.GetSerializedPersons();

            Assert.That(personJsonString, Is.EqualTo(expected));
        }
    }
}
