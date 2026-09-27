namespace Route.OOP03.Overriding
{
    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }

        public FullTimeEmployee(int id, string name, decimal salary, decimal bonus): base(id, name)
        {
            Salary = salary;
            Bonus = bonus;
        }

        // Method Hiding (static / compile-time polymorphism): `new` shadows
        // The base version is not deleted - both still exist, and the declared REFERENCE type decides which one a given call resolves to.
        public new void PrintInfo()
        {
            Console.WriteLine($"[Full-Time Employee]: Id:{Id}, Name: {Name}, Salary: {Salary}, Bonus:{Bonus} ");
        }


        // Method Overriding (dynamic / run-time polymorphism): the actual OBJECT decides which CalculateSalary() body runs, no matter what  the reference is declared as.
        public override decimal CalculateSalary()
        {
            return Salary + Bonus;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Salary} {Bonus}";
        }

        public override void Test()
        {
            base.Test();
        }

    }

    class TestEmployee : FullTimeEmployee
    {
        public string Position { get; set; }
        public TestEmployee(int id, string name, decimal salary, decimal bonus, string position) : base(id, name, salary, bonus)

        {
            Position = position;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Position}";
        }

    }
}
