using System;

namespace BuilderDesignPattern2
{
    public class Person
    {
        public string Name;
        public string Position;

        public class Builder : PersonJobBuilder<Builder>
        {
            
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    } 

    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
    
    public class PersonInfoBuilder<SELF> : PersonBuilder
          where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return this as SELF;
        }
    }

    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
    where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return this as SELF;
        }
    }
    
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