namespace DemoCleanCode.Entities
{
    public class SalariedEmployee : EmployeeBase
    {   
        private const decimal HOURLY_RATE = 1.8M;

        public override decimal GetHourlyRate()
        {
            return HOURLY_RATE;
        }
    }
}
