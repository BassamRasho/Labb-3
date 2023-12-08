using Labb_3;

namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            String name = "Bassam Rasho";
            Gender gender = Gender.Man;
            Hair hair = new Hair { HairColor = "Brown", HairLength = "35 cm long" };
            DateTime birthday = new DateTime(1998, 5, 6);
            string eyesColor = "Brown";

            Person person = new Person(name, hair, gender, birthday, eyesColor);

            Console.WriteLine(person.ToString());

            Console.ReadKey();
        }
    }
}
