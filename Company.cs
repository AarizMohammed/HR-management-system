using System;
namespace W4B_HR_Example
{
	public class Company
	{
		private List<Employee> _employees = new List<Employee>();


		//public void AddEmployee(string name, double salary)
		//{
		//	Employee emp = new Employee { Name = name, Salary = salary };

  //      }

        public bool AddEmployee(Employee employee)
        {
			//todo 1: dont add 2 employees with the same email

			foreach (Employee emp in _employees)
			{
				if (employee.Email.ToLower() == emp.Email.ToLower())
					return false;
			}

			employee.Id = _employees.Count + 1;

            _employees.Add(employee);
			return true;
        }

		public double GetAverageSalary()
		{
			if (_employees.Count == 0)
				return 0;


			double total = 0;
			foreach(Employee employee in _employees)
			{
				total += employee.Salary;
			}
			return total / _employees.Count;
		}

		public bool EmployeeExist(string name)
		{
            foreach (Employee emp in _employees)
            {
				if (name.ToLower() == emp.Name.ToLower())
					return true;
            }
			return false;
        }

		public Employee GetEmployeeWithHighestSalary()
		{
			if (_employees.Count == 0)
				return null;

			double maxSalary = 0;
			Employee employee = null;

			foreach(Employee emp in _employees)
			{
				if (emp.Salary > maxSalary)
				{
					maxSalary = emp.Salary;
					employee = emp;

                }
			}

			return employee;

		}


    }
}

