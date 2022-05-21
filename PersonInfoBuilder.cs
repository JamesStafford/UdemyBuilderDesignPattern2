namespace BuilderDesignPattern2
{
    public class PersonInfoBuilder<TSelf> : PersonBuilder
        where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return this as TSelf;
        }
    }
}