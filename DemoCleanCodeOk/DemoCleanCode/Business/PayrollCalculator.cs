using System;
using DemoCleanCode.Interfaces;
using DemoCleanCode.Persistence;

namespace DemoCleanCode.Business
{   
    public class PayrollCalculator
    {   
        private readonly TimeSheetPersistance timeSheetPersistance;
        private readonly SalaryPersistance salaryPersistance;

        private readonly IEmployee employee;

        public PayrollCalculator(IEmployee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("employee");
            }

            this.employee = employee;

            this.timeSheetPersistance = new TimeSheetPersistance();

            this.salaryPersistance = new SalaryPersistance();
        }

        public decimal CalculatePayroll()
        {
            decimal normalSalary = this.GetNormalSalary();

            decimal salaryExtraHours = this.CalculateSalaryExtraHours();

            decimal finalSalary = normalSalary + salaryExtraHours;

            return finalSalary;
        }

        private decimal GetNormalSalary()
        {
            decimal normalSalary = this.salaryPersistance.GetSalary(this.employee.Id);

            return normalSalary;
        }

        private decimal CalculateSalaryExtraHours()
        {
            decimal hoursOvertime = this.timeSheetPersistance.GetHoursOvertime(this.employee.Id);

            decimal hourlyRate = this.employee.GetHourlyRate();

            decimal extraSalary = hoursOvertime * hourlyRate;

            return extraSalary;
        }
    }
}
