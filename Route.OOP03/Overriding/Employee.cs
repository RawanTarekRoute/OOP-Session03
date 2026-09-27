namespace Route.OOP03.Overriding
{
    public abstract class Employee : TestEmp
    {
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        // Not marked virtual, so a derived class cannot override this 
        // it can only be shadowed with `new` 
        public void PrintInfo()
        {
            Console.WriteLine($"[Employee] Id: {Id}, Name {Name}");
        }

        // Marked virtual, so a derived class CAN replace this behavior
        // The base gives a harmless default.
        public virtual decimal CalculateSalary()
        {
            return 0.0m;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }

        public override void Test()
        {
            Console.Write("Test");
        }

    }

    public class TestEmp
    {
        public virtual void Test()
        {

        }
    }
}
