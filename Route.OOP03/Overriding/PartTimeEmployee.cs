namespace Route.OOP03.Overriding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal WorkingHours { get; set; }
        public decimal HourlyRate { get; set; }
        public PartTimeEmployee(int id, string name, decimal workingHours, decimal hourlyRate): base(id, name)
        {
            WorkingHours = workingHours;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return WorkingHours * HourlyRate;
        }
    }
}
