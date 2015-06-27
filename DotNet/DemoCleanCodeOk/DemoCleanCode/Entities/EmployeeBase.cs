using System;
using DemoCleanCode.Interfaces;

namespace DemoCleanCode.Entities
{
    public abstract class EmployeeBase : IEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public EmployeeProfile Profile { get; set; }

        public virtual decimal GetHourlyRate()
        {
            throw new NotImplementedException();
        }
    }
}
