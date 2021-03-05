using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(int Id);
    }
}