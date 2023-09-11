using EmployeeGreeting.data;
using EmployeeGreeting.Data;

public class EmployeeRepository
{
    private readonly EmployeeDbContext _context;

    public EmployeeRepository(EmployeeDbContext context)
    {
        _context = context;
    }

    public List<Employee> GetAllEmployees()
    {
        return _context.Employees.ToList();
    }



  
}
