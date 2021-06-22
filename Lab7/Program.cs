using System;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Add new employees.");
                Console.WriteLine("2. Edit employees list.");
                Console.WriteLine("3. Remove employees.");
                Console.WriteLine("4. Show list of employees.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Please enter options (1-4): ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManager.Create();
                        break;
                    case 2:
                        employeeManager.Modify();
                        break;
                    case 3:
                        employeeManager.Delete();
                        break;
                    case 4:
                        employeeManager.Display();
                        break;
                }
            }
        }
    }
}

