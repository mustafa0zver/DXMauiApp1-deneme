using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System;

namespace DXMauiApp1
{
    public enum AccessLevel
    {
        Admin,
        User
    }

    public class Employee
    {
        string name;
        string resourceName;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (Photo == null)
                {
                    resourceName = "Images/pr.png";
                    if (!String.IsNullOrEmpty(resourceName))
                        Photo = ImageSource.FromFile(resourceName);
                }
            }
        }

        public Employee(string name)
        {
            this.Name = name;
        }
        public ImageSource Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
    }

    public class EmployeeData
    {
        void GenerateEmployees()
        {
            ObservableCollection<Employee> result = new ObservableCollection<Employee>();
            result.Add(
                new Employee("Nancy Davolio")
                {
                    BirthDate = new DateTime(1978, 12, 8),
                    Position = "Sales Representative",
                    Phone = "(206) 555-9857",
                }
            );
            result.Add(
                new Employee("Andrew Fuller")
                {
                    BirthDate = new DateTime(1965, 2, 19),
                    Position = "Vice President, Sales",
                    Phone = "(206) 555-9482",
                }
            );
            result.Add(
                new Employee("Janet Leverling")
                {
                    BirthDate = new DateTime(1985, 8, 30),
                    Position = "Sales Representative",
                    Phone = "(206) 555-3412",
                }
            );
            result.Add(
                new Employee("Margaret Peacock")
                {
                    BirthDate = new DateTime(1973, 9, 19),
                    Position = "Sales Representative",
                    Phone = "(206) 555-8122",
                }
            );
            result.Add(
                new Employee("Steven Buchanan")
                {
                    BirthDate = new DateTime(1955, 3, 4),
                    Position = "Sales Manager",
                    Phone = "(71) 555-4848",
                }
            );
            result.Add(
                new Employee("Michael Suyama")
                {
                    BirthDate = new DateTime(1981, 7, 2),
                    Position = "Sales Representative",
                    Phone = "(71) 555-7773",
                }
            );
            result.Add(
                new Employee("Robert King")
                {
                    BirthDate = new DateTime(1960, 5, 29),
                    Position = "Sales Representative",
                    Phone = "(71) 555-5598",
                }
            );
            result.Add(
                new Employee("Laura Callahan")
                {
                    BirthDate = new DateTime(1985, 1, 9),
                    Position = "Inside Sales Coordinator",
                    Phone = "(206) 555-1189",
                }
            );
            result.Add(
                new Employee("Anne Dodsworth")
                {
                    BirthDate = new DateTime(1980, 1, 27),
                    Position = "Sales Representative",
                    Phone = "(71) 555-4444",
                }
            );
            Employees = result;
        }

        public ObservableCollection<Employee> Employees { get; private set; }

        public EmployeeData()
        {
            GenerateEmployees();
        }
    }
}