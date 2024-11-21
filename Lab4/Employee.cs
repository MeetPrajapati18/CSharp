using System;

class Employee : IComparable<Employee>
{
    public string Name { get; set; } // Auto-implemented property for Name
    public int Number { get; set; } // Auto-implemented property for Number
    public decimal Rate { get; set; } // Auto-implemented property for Rate
    public double Hours { get; set; } // Auto-implemented property for Hours

    public Employee(string name, int number, decimal rate, double hours)
    {
        Name = name;
        Number = number;
        Rate = rate;
        Hours = hours;
    }

    // Calculates gross pay
    public decimal GrossPay => (decimal)Hours * Rate;

    // String representation of the Employee object
    public override string ToString()
    {
        return $"Name: {Name}, Number: {Number}, Rate: {Rate:C}, Hours: {Hours}, Gross Pay: {GrossPay:C}";
    }

    // Implement IComparable for default sorting by Name
    public int CompareTo(Employee? other)
    {
        return string.Compare(Name, other?.Name, StringComparison.OrdinalIgnoreCase);
    }
}
