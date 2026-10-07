namespace Session_6
{
    public class Doctor : Person

    {
        public string Specialty { get; set; }
        public Doctor(int id, string name, int age, string specialty)
            : base(id, name, age)
        {
            Specialty = specialty;
        }
        public new void Greet()
        {
            Console.WriteLine("Hello, I am a Doctor!");
        }
        public override void Display()
        {
            Console.WriteLine($"[Doctor] ID: {ID}, Name: {Name}, Age: {Age}, Specialty: {Specialty}");
        }
    }
}
