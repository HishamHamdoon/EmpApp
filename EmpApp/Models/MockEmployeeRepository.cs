using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1,Name = "Marry",Email = "marry@gmail.com",Department=Dept.Hr},
                new Employee() {Id=2,Name = "Ahmed",Email = "ahmed@gmail.com",Department=Dept.Developmet},
                new Employee() {Id=3,Name = "Musa",Email = "Musa@gmail.com",Department=Dept.Finance},
                new Employee() {Id=4,Name = "Mohammed",Email = "mohammed@gmail.com",Department=Dept.IT},
                new Employee() {Id=5,Name = "ali",Email = "ali@gmail.com",Department=Dept.Network},
                new Employee() {Id=6,Name = "Ahmed",Email = "ahmed@gmail.com",Department=Dept.Finance},
                new Employee() {Id=7,Name = "Musa",Email = "Musa@gmail.com",Department=Dept.IT}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(x=>x.Id)+1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
           Employee employee = _employeeList.Find(x=>x.Id==id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

      
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {

            return _employeeList.FirstOrDefault(x => x.Id == id);

        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.Find(x => x.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }

            return employee;
        }
    }
}
