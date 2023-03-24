namespace Objektorientering
{
    internal class Classroom
    {
        public class Person
        {
            public string Name { get; private set; }
            public Person(string name)
            {
                Name = name;
            }
        }


        public static void Main(string[] args)
        {
            var person1 = new Person("Terje");
            var person2 = new Person("Poly");

            List<Person> listOfPeople = new List<Person>();
            listOfPeople.Add(person1);
            listOfPeople.Add(person2);
            foreach (Person person in listOfPeople)
            {
                Console.WriteLine(person.Name);

            }


        }

    }
}