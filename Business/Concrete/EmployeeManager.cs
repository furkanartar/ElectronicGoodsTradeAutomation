using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.Employees.Add(employee.FirstName, employee.LastName));
        }

        public IResult Update(Employee employee)
        {
            var result = _employeeDal.Get(e => e.Id == employee.Id);
            _employeeDal.Delete(result);
            return new SuccessResult(Messages.Employees.Update(employee.FirstName, employee.LastName));
        }

        public IResult Delete(Employee employee)
        {
            var result = _employeeDal.Get(e => e.Id == employee.Id);
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.Employees.Delete(employee.FirstName, employee.LastName));
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll());
        }

        public IDataResult<Employee> GetById(int EmployeeId)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(c => c.Id == EmployeeId));
        }
    }
}