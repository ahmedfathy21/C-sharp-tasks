
namespace MyLinQ;

public static class Data
{
    public static List<Employee> GetEmployess()
    {
        List<Employee> employess = new List<Employee>();

        Employee employee = new Employee(id: 1, firstName: "Ahmed", lastName: "Fathy", age: 23, salary: 10000.5m,
            isManger: true, departmentId: 1);
        employess.Add(employee);
        employee = new Employee(id: 2, firstName: "Sarah", lastName: "Mahdy", age: 25, salary: 5250.6m, isManger: false,
            departmentId: 2);
        employess.Add(employee);

        employee = new Employee(id: 3, firstName: "Fares", lastName: "Mohamed", age: 30, salary: 7525.5m,
            isManger: false, departmentId: 1);
        employess.Add(employee);
            return employess;
    }

    public static List<Department> GetDepartments()
    {
        List<Department> departments = new List<Department>();

        Department department = new Department
        {
            DepartmentId = 1,
            ShortName = "HR",
            LongName = "Human Resource",
        };
        departments.Add(department);
         department = new Department
        {
            DepartmentId = 2,
            ShortName = "Dev",
            LongName = "Development",

        };
        departments.Add(department);
        department = new Department
        {
            DepartmentId = 3,
            ShortName = "CY",
            LongName = "CyperSecurity",
        };
        departments.Add(department);

        return departments;
    }

   
}