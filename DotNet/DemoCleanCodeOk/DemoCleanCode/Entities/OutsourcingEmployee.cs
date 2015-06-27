namespace DemoCleanCode.Entities
{
    public class OutsourcingEmployee : EmployeeBase
    {
        private const decimal HOURLY_RATE = 1.1M;

        public override decimal GetHourlyRate()
        {
            return HOURLY_RATE;
        }
    }
}
