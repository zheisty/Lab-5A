using System;

class MainClass
 {
  public static void Main (string[] args) 
  {
    Employee employee1 = new Employee ();
    // constructor with no parameters 
    employee1.Intro();

   
    Employee employee2 = new Employee("Robert", "Downey", "12321", 12);

    employee2.Intro();
   employee2.Yearlysalary = 100;
   Console.WriteLine ("Yearly Salary: " + employee2.Yearlysalary);




  Employee employee3 = new Employee("John", "Smith", "S0089", 38);
   
    employee3.Intro();
    employee3.Yearlysalary = 50000;
   Console.WriteLine ("Yearly Salary: " + employee3.Yearlysalary);
   Console.WriteLine ("Input Salary Bonus:");
   employee3.IncreaseSalary();
   employee3.Employmentstatus = "active";
   employee3.RemoveEmployee();
    
  Employee employee4 = new Employee("Maria", "Lambert", "S0010", 26);
    employee4.Intro();
    employee4.Yearlysalary = 80000;
   Console.WriteLine ("Yearly Salary: " + employee4.Yearlysalary);
    Console.WriteLine ("Input Salary Bonus:");
   employee4.IncreaseSalary();
   employee4.Employmentstatus = "active";
   employee4.RemoveEmployee();

  }
  }