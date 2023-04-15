namespace ConsoleApp1
{
    public class Account
    {
        int Id;
        string Name;
        decimal Salary;
        public void create(int id, string name, decimal salary)
        {
            Id=id;
            Name=name;
            Salary=salary;
            Console.WriteLine("acc created successfully");
        }
    }
}