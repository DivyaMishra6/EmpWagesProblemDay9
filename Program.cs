using EmployeeWageDay9;

namespace EmployeeWagesProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage Problem");

            EmployeeCheckUC1 attendance = new EmployeeCheckUC1();
            attendance.EmployeeAttendence();

            CalculateEmpWagesUC2 wage = new CalculateEmpWagesUC2();
            wage.EmployeeWages();

            AddPartTimeUC3 parttime = new AddPartTimeUC3();
            parttime.Wages();

            EmpWagesUsingSwitchCase switchcase = new EmpWagesUsingSwitchCase();
            switchcase.Case();

            WageForMonthUC5 month = new WageForMonthUC5();
            month.WageForMonth();

            //DaysCalculateUC6 days = new DaysCalculateUC6();
           // days.MaxDaysMaxHoursWage();

            //MethodToComputeEmpWageUC7.EmpWageUseCase7();




        }
    }


}
