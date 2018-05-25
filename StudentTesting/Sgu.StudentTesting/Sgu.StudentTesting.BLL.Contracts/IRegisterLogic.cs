using Common.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL.Contracts
{
    public interface IRegisterLogic
    {
        IEnumerable<City> GetCity();
        IEnumerable<University> GetUniversity();
        IEnumerable<Faculty> GetFaculty();
        IEnumerable<Direction> GetDirection();
    }
}
