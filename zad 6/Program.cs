namespace zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.AddEmployee(new Employee("John", 5000));
            company.AddEmployee(new Employee("Bill", 3000));
            company.AddEmployee(new Employee("Steve", 2000));
            company.AddEmployee(new Employee("Elon", 10000));
            company.AddEmployee(new Employee("Jeff", 15000));

            company.SearchEmployee("Elon");
            company.SearchEmployee("Bill");
        }
    }
}
