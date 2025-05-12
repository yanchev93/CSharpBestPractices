using HelperLibrary;

// Capturing a number of people's names
// Loop through and say hi to them

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is bad way to write code. The Main method do more than one thing.
            List<Person> people = new List<Person>();

            people.Add(new Person { FirstName = "Teodor", LastName = "Yanchew" });
            people.Add(new Person { FirstName = "Petko", LastName = "Petkov" });
            people.Add(new Person { FirstName = "John", LastName = "Conrad" });

            foreach (Person person in people)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }

            Console.ReadLine();
        }
    }
}
