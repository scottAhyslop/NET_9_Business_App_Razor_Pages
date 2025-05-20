using NET_9_Business_App_RazorPages.Models;

namespace NET_9_Business_App_Razor_Pages.Models
{
    public static class EmployeesRepository
    {
        //Sample data for testing

        #region Sample Data
        //Sample data for the Employee Model
        private static List<Employee> _employees = new List<Employee>
            {
            new Employee(1,"Ozzy","Osbourne", "Membranophone Specialist","Vocals", 500000),
            new Employee(2,"Tony", "Iommi", "Guitar Player", "Guitars", 500000),
            new Employee(3,"Geezer", "Butler", "Bass Player", "Guitars", 500000),
            new Employee(4,"Bill", "Ward", "Bongos", "Percussion", 500000),
            };

        #endregion

      
        public static List<Employee> GetEmployees(string? filter = null, int? departmentId = null)
        {
            foreach (Employee emp in _employees)
            {
                //emp.EmployeeDepartment = 
            }
            return _employees;

        }//end GetDepartments with string filter

        //GET by Id
        public static Employee? GetDepartmentById(int id)
        {
            return _employees.FirstOrDefault(emp => emp.EmployeeId == id);
        }//end GetDepartmentById

        //POST Add department
        public static void AddEmployee(Employee? employee)
        {
            //Check if the department is null
            if (employee is null)
            {
                //If it is null, return null obj
                return;
            }
            else
            {
                int maxId = _employees.Max(emp => emp.EmployeeId);
                employee.EmployeeId = maxId + 1;
                employee.EmployeeFirstName = employee.EmployeeFirstName;
                employee.EmployeeLastName = employee.EmployeeLastName;
                employee.EmployeePosition = employee.EmployeePosition;
                employee.EmployeeDepartment = employee.EmployeeDepartment;
                employee.EmployeeSalary = employee.EmployeeSalary;
                //Add the new employee to the list
                _employees.Add(employee);
            }
        }
        //end AddDepartment

        //POST Update department
        public static bool UpdateEmployee(Employee? employee)
        {
            //null check for employee object
            if (employee is not null)
            {
                // Find the employee to update in the _employees list
                var empSelect = _employees.FirstOrDefault(emp => emp.EmployeeId == employee.EmployeeId);
                if (empSelect is not null)
                {
                    // Update the selected employee properties from the provided employee object
                    empSelect.EmployeeFirstName = employee.EmployeeFirstName;
                    empSelect.EmployeeLastName = employee.EmployeeLastName;
                    empSelect.EmployeePosition = employee.EmployeePosition;
                    empSelect.EmployeeDepartment = employee.EmployeeDepartment;
                    empSelect.EmployeeSalary = employee.EmployeeSalary;

                    return true;//return that update was successful
                }//end depSelect null check                
            }//end department null check
            return false;
        }

        //DELETE By DepartmentId
        public static bool DeleteEmployee(Employee? employee)
        {
            //null check for employee object
            if (employee is not null)
            {
                // Find the employee to delete in the _employees list
                var delEmp = _employees.FirstOrDefault(emp => emp.EmployeeId == employee.EmployeeId);
                //null check for selected employee object
                if (delEmp is not null)
                {
                    // Remove the department from the list
                    _employees.Remove(delEmp);
                    return true;
                }
                else
                {
                    // If the department is not found, return false
                    return false;
                } // end delDep null check
            } // end department null check
            // If the department is null, return false
            return false;
        }
        //end DeleteDepartment
    }//end DepartmentsRepository
}
