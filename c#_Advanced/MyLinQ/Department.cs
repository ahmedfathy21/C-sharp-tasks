namespace MyLinQ;

public class Department
{
    
    public int DepartmentId { get; set; } 
    public string ShortName { get; set; }
    public string LongName { get; set; }


    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override string ToString() =>  $" DepartmentId : {DepartmentId} , ShortName : {ShortName} , LongName : {LongName}";
    
}