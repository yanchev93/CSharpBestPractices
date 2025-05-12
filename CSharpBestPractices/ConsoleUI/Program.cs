using HelperLibrary;

// Capturing a number of people's names
// Loop through and say hi to them

namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            // Now the Main method is only calling helper methods
            SetUpSampleData();

            GreetAllThePeople();

            Console.ReadLine();
        }

        private static void SetUpSampleData()
        {
            people.Add(new Person { FirstName = "Teodor", LastName = "Yanchew" });
            people.Add(new Person { FirstName = "Petko", LastName = "Petkov" });
            people.Add(new Person { FirstName = "John", LastName = "Conrad" });
        }

        private static void GreetAllThePeople()
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }
        }
    }
}
