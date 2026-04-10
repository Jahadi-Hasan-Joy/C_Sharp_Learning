namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void seeData(List<IEmployee>employees)
        {

        }
    }

    public interface IEmployee
    {
    }

    public class Teacher : EmployeeBase
    {

    }

    public class EmployeeBase
    {
    }

    public class HeadOfDepartment : EmployeeBase
    {
        
    }
    public class DeputyHeadMaster : EmployeeBase
    {

    }
    public class HeadMaster : EmployeeBase
    {

    }

}