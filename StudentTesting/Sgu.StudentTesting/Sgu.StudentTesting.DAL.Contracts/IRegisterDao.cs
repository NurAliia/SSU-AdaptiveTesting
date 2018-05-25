using System.Collections.Generic;
using Common.Register;

namespace Sgu.StudentTesting.DAL.Contracts
{
    public interface IRegisterDao
    {
        IEnumerable<City> GetCity();
        IEnumerable<University> GetUniversity();
        IEnumerable<Faculty> GetFaculty();
        IEnumerable<Direction> GetDirection();
    }
}
