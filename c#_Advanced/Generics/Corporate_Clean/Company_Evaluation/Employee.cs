namespace Company_Evaluation;

public class Employee
{
    public Employee(int id, string? name, decimal loggedHours, decimal wage)
    {
        Id = id;
        Name = name;
        Logged_hours = loggedHours;
        Wage = wage;
    }

    public const int MiniLoggedHours = 45;
    public const decimal OvertimeRatePerhour = 1.5m;
    protected int Id { get; set; }
    protected string? Name { get; set; }
    protected decimal Logged_hours { get; set; }
    protected  decimal Wage { get; set;  }

    public virtual decimal CalucateNETSalary()
    {
        return (Wage  * Logged_hours);
        
    }

    public virtual decimal CalucateOvertimeSalary()
    {
        var overtime = Logged_hours - MiniLoggedHours > 0 ? Logged_hours - MiniLoggedHours : 0;
        
        return  (overtime * OvertimeRatePerhour * Wage);

    }

    public virtual decimal CalucateSalary()
    {
        return (CalucateNETSalary() + CalucateOvertimeSalary());
    }

    public override string ToString()
    {
        return $" {Id} - {Name} - {Logged_hours} - {Wage} - {CalucateSalary()}";
    }
}
public class Manger : Employee
{
    public const decimal AllowanceRate =  0.05m;
    public string Department { get; set; }   

    public Manger(int id, string? name, decimal loggedHours, decimal wage , string department) : base(id, name, loggedHours, wage)
    {
        this.Department = department;

    }

    override public decimal CalucateSalary()
{
        return base.CalucateSalary() + (AllowanceRate * base.CalucateSalary());
}
}

public class Developer : Employee
{
    public const decimal AllowanceRate = 0.02m;
    public string Track { get; set; }
    public Developer(int id, string? name, decimal loggedHours, decimal wage, string track) : base(id, name, loggedHours, wage)
    {
        this.Track = track;
    }

    override public decimal CalucateSalary()
    {
        return (base.CalucateSalary() + (AllowanceRate * base.CalucateSalary()));
    }
}

public class Sales : Employee
{
    public decimal commission { get; set; }
    public Sales(int id, string? name, decimal loggedHours, decimal wage , decimal commission ) : base(id, name, loggedHours, wage)
    {
        this.commission = commission;
        
    }
    override public decimal CalucateSalary()
    {
        return (base.CalucateSalary() + (commission * base.CalucateSalary()));
    }
}
