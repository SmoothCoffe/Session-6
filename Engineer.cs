namespace Session_6
{
    public class Engineer : Person
    {
        public string Field { get; set; }
        public Engineer(int id, string name, int age, string field)
            : base(id, name, age)
        {
            Field = field;
        }
        public new void Greet()
        {
            Console.WriteLine("Hello, I am an Engineer!");
        }
        public override void Display()
        {
            Console.WriteLine($"[Engineer] ID: {ID}, Name: {Name}, Age: {Age}, Field: {Field}");
        }
    }
}
