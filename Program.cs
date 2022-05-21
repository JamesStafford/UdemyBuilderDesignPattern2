using System;

namespace BuilderDesignPattern2
{
    internal class Program
    {
        public static void Main()
        {
            Person person = Person.New
                .Called("James")
                .WorksAsA("Programmer")
                .Build();
            Console.WriteLine(person);
        }
    }
}