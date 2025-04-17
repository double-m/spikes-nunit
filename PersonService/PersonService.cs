using System.Text.Json;

namespace PersonServices
{
    public class PersonService
    {
        public string GetSerializedPersons()
        {
            var person1 = new PersonData();
            person1.FirstName = "Alessio";
            person1.LastName = "Rossi";
            person1.Age = 30;

            var person2 = new PersonData();
            person2.FirstName = "Barbara";
            person2.LastName = "Verdi";
            person2.Age = 30;

            return JsonSerializer.Serialize<List<PersonData>>([person1, person2]);
        }
    }
}

class PersonData
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
}
