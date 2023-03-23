namespace Objektorientering
{
    internal class Classroom
    {
        public class Person
        {
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {
            var person = new Person();
            var name = person.Name;

            Console.WriteLine(person.Name);
        }

    }
}