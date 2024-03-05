# Exp03-Constructor
## Aim: 
To write a C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor.

## Algorithm:
## Step1:
Initialize the program with the system library

## Step2:
Define the Employee Class and set it as public

## Step3:
Define the variables

## Step4:
Write a parameterized constructor under the class Employee

## Step5:
Define a function to calculate the salary

## Step6:
Define the display() function to print the output
## Program:
#### Developed by:Shaik Sameer Basha
#### Register Number:212222240093
```python
using System;
namespace Constructor1
{
    public class Program
    {
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
```


## Output:
![output](/output.png)

## Result:
Thus, a C# program is written to calculate the salary of an employee using a constructor is implemented and the output is verified.