using System;
namespace Constructor1
{
    public class Program
    {
        // type the code here
        public void display(int basic_salary,int insurance_amount)
        {
            float total_sal;
            int hra = (20*basic_salary)/100;
            int ts = (10*basic_salary)/100;
            total_sal=basic_salary+hra+ts- insurance_amount;
            Console.WriteLine("\nTotal Salary ="+total_sal);
        }
    }
    public class emp
    {
        string name;
        string destignation;
        int noofexperience, basic_salary, insurance_amount;
        public emp(string name, string destignation, int basic_salary, int noofexperience, int insurance_amount)
        {
            this.name = name;
            this.destignation = destignation;
            this.noofexperience = noofexperience;
            this.basic_salary = basic_salary;
            this.insurance_amount = insurance_amount;

        }
    }
    public class Exp3
    {
        static void Main(String[] args)
        {
            // type the code here
            string name,destignation;
            int basic_salary,noofexperience, insurance_amount;
            Console.WriteLine("What is Name");
            name = Console.ReadLine();
            Console.WriteLine("What is destignation");
            destignation = Console.ReadLine();
            Console.WriteLine("What id basic salary");
            basic_salary=int.Parse(Console.ReadLine());
            Console.WriteLine("What is experience");
            noofexperience = int.Parse(Console.ReadLine());
            Console.WriteLine("what is insurance Amount");
            insurance_amount =int.Parse(Console.ReadLine());
            emp EM = new emp(name,destignation,basic_salary,noofexperience,insurance_amount);
            Program obj = new Program();
            obj.display(basic_salary, insurance_amount);
        }
    }
}