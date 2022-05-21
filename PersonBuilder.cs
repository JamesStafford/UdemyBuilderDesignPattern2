namespace BuilderDesignPattern2
{
    public abstract class PersonBuilder
    {
        protected readonly Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }
}