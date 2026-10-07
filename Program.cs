// See https://aka.ms/new-console-template for more information


#region Session 6 Part 01
//Design and implement a Class for the employees in a company:

//Employee[] EmpArr = new Employee[3];
//SecurityPrivilege[] roles = { SecurityPrivilege.DBA, SecurityPrivilege.Guest, SecurityPrivilege.SecurityOfficer };
//Console.WriteLine("Emplyee System\n");
//for (int i = 0; i < EmpArr.Length; i++)
//{
//    Console.WriteLine($"Enter Data for emplyee number [{i + 1}] ");

//    int id;
//    Console.Write("Enter Emplyee ID: ");
//    while (!int.TryParse(Console.ReadLine(), out id))
//    {
//        Console.Write("Wrong ID, Enter Right ID");
//    }

//    Console.Write("Enter Employee Name: ");
//    string? name = Console.ReadLine();

//    Gender gender;
//    Console.Write("Enter Employee Gender (M or F):");
//    while (!Enum.TryParse<Gender>(Console.ReadLine(), true, out gender))
//    {
//        Console.Write("Invalid Gender! Please enter a valid Gender: ");
//    }

//    decimal salary;
//    Console.Write("Enter Emplyee salary: ");
//    while (!decimal.TryParse(Console.ReadLine(), out salary))
//    {
//        Console.Write("Invalid salary! Please enter a valid numeric salary: ");
//    }

//    int day, month, year;
//    Console.Write("Enter Hire Day (1-31): ");
//    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
//    {
//        Console.Write("Invalid Day! Enter a day between 1 and 31: ");
//    }

//    Console.Write("Enter Hire Month (1-12): ");
//    while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
//    {
//        Console.Write("Invalid Month! Enter a month between 1 and 12: ");
//    }

//    Console.Write("Enter Hire Year: ");
//    while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > 2100)
//    {
//        Console.Write("Invalid Year! Enter a valid year: ");
//    }

//    HiringDate hireDate = new HiringDate(day, month, year);

//    SecurityPrivilege securityLevel = roles[i];

//    EmpArr[i] = new Employee(id, name!, securityLevel, salary, hireDate, gender);
//    Console.WriteLine("\n-----------------------------------\n");

//}

//Console.WriteLine("\nEmplyee System\n");
//foreach (var emp in EmpArr)
//{
//    Console.WriteLine(emp.ToString());
//}
//public enum Gender
//{
//    M = 1,
//    F = 2
//}

//[Flags]
//public enum SecurityPrivilege
//{
//    Guest = 1,
//    Developer = 2,
//    Secretary = 4,
//    DBA = 8,
//    SecurityOfficer = Guest | Developer | Secretary | DBA
//}

//public class HiringDate
//{
//    public int Day { get; set; }
//    public int Month { get; set; }
//    public int Year { get; set; }

//    public HiringDate(int day, int month, int year)
//    {
//        Day = day;
//        Month = month;
//        Year = year;
//    }

//    public override string ToString()
//    {
//        return $"{Day:D2}/{Month:D2}/{Year}";
//    }
//}

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public SecurityPrivilege SecurityLevel { get; set; }
//    public decimal Salary { get; set; }
//    public HiringDate HireDate { get; set; }
//    public Gender Gender { get; set; }

//    public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, HiringDate hireDate, Gender gender)
//    {
//        Id = id;
//        Name = name;
//        SecurityLevel = securityLevel;
//        Salary = salary;
//        HireDate = hireDate;
//        Gender = gender;
//    }

//    public override string ToString()
//    {
//        return string.Format("ID: {0} | Name: {1} | Gender: {2} | Security Level: {3} | Salary: {4:C} | Hire Date: {5}",
//            Id, Name, Gender, SecurityLevel, Salary, HireDate);
//    }
//}

#endregion

using Session_6;

#region session 6 part 02
//Q1
//Shape react = new Rectangle(5, 4);
//Console.WriteLine($"Rectangle Dimensions {react}");
//Console.WriteLine($"Area = {react.Area()}");

//Q2
//Cube myCube = new Cube(2, 3, 4);
//Console.WriteLine($"Cube Dimensions {myCube}");
//Console.WriteLine($"Cube Area = {myCube.Area()}");

//Q3
//Shape shape = new Shape(2, 3); → call Area() — what is printed?
// Compile Error CS0144 and nothing is printed.

//Cube cube = new Cube(2, 3, 4); → call Area() — what is printed?
//24

//Shape shapeRef = new Cube(2, 3, 4); → call Area() — what is printed and why? Explain 
//Shape shapeRef = new Cube(2, 3, 4);
//Console.WriteLine($"Cube Area = {shapeRef.Area()}");
//24 When using `override`, dynamic binding(late/dynamic binding) occurs at runtime.

//Q4
//object obj = new Cube(1, 2, 3);
//Console.WriteLine(obj.ToString());

//Width = 1, Height = 2, Depth = 3
//The ToString() function defined within the Cube class will work!
//The top-level class `Object` (the base class for all classes in C#) defines the `ToString()` method as `virtual`.
//When we implemented `ToString()` within the `Cube`, `Rectangle`, or `Shape` classes, we used the `override` keyword.
//The `override` keyword instructs the compiler to use dynamic binding at runtime
//and always invoke the version of the method corresponding to the object's actual type in memory (e.g., `Cube`).

//Q5 - Q6 - Q7 - Q8
static void ProcessPerson(Person person)
{
    person.Greet();
    person.Display();
}
Person doc = new Doctor(101, "Dr. Bassem", 30, "Neurology");
Person eng = new Engineer(102, "Eng. Bassem", 28, "Software");

Console.WriteLine("--- Processing Doctor ---");
ProcessPerson(doc);

Console.WriteLine("\n--- Processing Engineer ---");
ProcessPerson(eng);

//Q8. What happens if you remove virtual from Display() in Person?
//Error CS0115: 'Doctor.Display()': no suitable method found to override


//What compiler warning/error appears in the derived classes, and what does it mean?
//Warning CS0114: 'Doctor.Display()' hides inherited member 'Person.Display()'.
//To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.

//The function in the child class now performs method hiding of the parent function instead of overriding it
//and it prompts you to explicitly use the `new` keyword to confirm this intention.

#endregion

//Q15
//Feature 1: Base Class Keyword

//Static Binding (new): No special keyword is required in the base method (it can be a standard method).

//Dynamic Binding (override): Requires the virtual keyword (or abstract / override) in the base method.

//Feature 2: Derived Class Keyword

//Static Binding (new): Uses the new keyword(Method Hiding).

//Dynamic Binding(override): Uses the override keyword (Method Overriding).

//Feature 3: Resolution Time

//Static Binding (new): Resolved at Compile Time 🔒.

//Dynamic Binding (override): Resolved at Runtime 🔄.

//Feature 4: Behavior via Base Reference

//Static Binding (new): Calls the base class method(based on the reference type).

//Dynamic Binding(override): Calls the derived class method(based on the actual object type in memory).

//Q16
//The reason behind `override` (Dynamic Binding):
//C# requires the `virtual` keyword in the base class as a form of "opt-in" architecture.
//By using this keyword, the base class designer declares: "I permit derived classes to modify this method's behavior at runtime."
//Without `virtual`, all C# methods are closed to dynamic modification by default to protect the design.

//The reason behind `new` (Static Binding / Method Hiding):
//The `new` keyword does not modify the original method in the base class, nor does it participate in polymorphism.
//instead, it simply creates an entirely new method in the derived class that happens to share the same name.
//Since it is a completely independent method that effectively hides the old one
//it requires no permission from the base class and works with any method.