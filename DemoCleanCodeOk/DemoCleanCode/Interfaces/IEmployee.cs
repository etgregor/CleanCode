using DemoCleanCode.Entities;

namespace DemoCleanCode.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        
        string Name { get; set; }
        
        int Age { get; set; }
        
        EmployeeProfile Profile { get; set; }

        decimal GetHourlyRate();
    }
}
