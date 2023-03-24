namespace Objektorientering
{
    internal class Classroom
    {
        public class Person
        {
            public string Name { get; private /*(Med denne kan ikke person.Name funke)*/ set; }
        }


        static void Main(string[] args)
        {
            var person = new Person();
            var name = person.Name;
            //person.Name = "Dick";

            Console.WriteLine(person.Name);
        }

    }
}