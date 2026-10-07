namespace Session_6
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine("I am a personand my basic data is ");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
        }
    }
}
