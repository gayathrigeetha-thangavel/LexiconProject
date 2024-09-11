
using System.Xml.Schema;

public class Employee{
    public string emp_Name;
    public int emp_salary;

    public void insert(string name, int salary){
        emp_Name = name;
        emp_salary = salary;
    }
   public void display(){

        Console.WriteLine("Employee name and salary details:\nname: "+emp_Name +"\nsalary: "+ emp_salary);

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();

        Console.WriteLine("Enter the employee name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter the employee salary:");
        int salary = Convert.ToInt32(Console.ReadLine());

        try{
            inputValidation(name, salary);
        }
        catch(NullReferenceException exp){
            Console.WriteLine(exp); 
        }

        Console.WriteLine("Employee Register:\n");
        employee.insert(name, salary);
        employee.display();
     }

    private static void inputValidation(string in_Name, int in_Salary)
    {
        if(in_Name == string.Empty || in_Name == null)
        {
            throw new NullReferenceException("Name should not be null");
        }
        if(in_Salary == 0)
        {
            throw new NullReferenceException("Salary should not be zero");
        }
        
    }
}

