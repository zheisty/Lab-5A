using System;


    class Employee
    {//below are my fields
        private string firstname;
        private string lastname;
        private  string id;
        private int age;
        private string address;
        private string phonenumber;
        private string title;
        private double yearlysalary;
        private string employmentstatus;
      //below are my properties
        //Auto Implemented properties

        public string Firstname
            {get; set;}
        public string Lastname
            {get; set;}
        public  string Id
            {get; set;}
        public string Employmentstatus 
            {get; set;}

        //Properties requiring validation
        //salary cant be less than 1000
        public double Yearlysalary 
        {
          get
          {
            return yearlysalary;
          }
          set 
          {
            if (value>= 1000)
              yearlysalary = value;

            else 
              yearlysalary = 1000;
          }
          //age cant be less than 18
        }
        public int Age
         {
          get
          {
              return age;
          }
          set
          {
            if(value>=18)
            age = value;
            else 
            age = 18;
          }
         }

      // below are constructors
        public Employee() //constructor no parameter
        {
            Firstname = "Unknown";
            Lastname = "Unknown";
            Id = "Unknown";
            Age = 0;

            Console.WriteLine ("New Employee Information:");

            //output for emplyee with no information 
        }
        public Employee (string efirstname, string elastname, string eid, int eage) //contructor with parameters
        {
            Firstname = efirstname;
            Lastname = elastname;
            Id = eid;
            Age = eage;
            Employmentstatus = "active";   
            Console.WriteLine ("New Employee Information:");
            // e standing for employee 
            // output for employees name (first and second) id and age
        }
       
        public void Intro()
        {

          Console.WriteLine ("First Name: " + Firstname);
          Console.WriteLine ("Last Name: " + Lastname);
          Console.WriteLine ("Age: " + Age);
          Console.WriteLine ("ID: " + Id);
    
        }

         public void IncreaseSalary()
        {
        
         double bonus= Convert.ToDouble(Console.ReadLine());;

          if (bonus <0)
          {
            Console.WriteLine ("invalid input. Yearly Salary not updated");
          }
          else
          {
           Console.WriteLine ("Updated Yearly Salary: " + (Yearlysalary+(Yearlysalary * bonus)));
          }

        
        }

        public void RemoveEmployee ()
        {
           if (Employmentstatus == "inactive")
          {
            Console.WriteLine ("Employee already inactive");
          }         
          else
          {
          Console.WriteLine("Employee Removed");
          }
        }

    }

       
        
    
