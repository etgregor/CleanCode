using System;
using DemoCleanCode.Entities;
using DemoCleanCode.Persistence;

namespace DemoCleanCode.Business
{
    public class PayrollCalculator
    {
        private const int PAYROLL_EMPLOYEE_NOT_FONUND = 0;

        TimeSheetPersistance timeSheetPersistance;

        public PayrollCalculator()
        {
            this.timeSheetPersistance = new TimeSheetPersistance();
        }
        public decimal CalculatePayroll(Employee employee)
        {
            Decimal payroll = PAYROLL_EMPLOYEE_NOT_FONUND;
            var salaryPersistance = new SalaryPersistance();

            var salary = salaryPersistance.GetSalary(employee.Id);

                if (salary != null)
                {
                    int hoursOvertime = this.timeSheetPersistance.GetHoursOvertime(employee.Id);

                    Decimal payrollExtra = this.calculatePayrollExtraHours(hoursOvertime, employee.IsOutsourcing);

                    payroll = salary + payrollExtra;
                }

            return payroll;
        }

        public decimal calculatePayrollExtraHours(int hoursWorked, bool isOutsorsing)
        {
            decimal payment;
            decimal hourlyRate;

            hourlyRate = GetHourlyRate(isOutsorsing);

            payment = hourlyRate * hoursWorked;

            return payment;
        }

        public decimal GetHourlyRate(bool isOutsorsing)
        {

            if (isOutsorsing)
                return 1.1M;
            else
                return 1.8M;
        }
    }
}
