using Common.Register;
using Sgu.StudentTesting.BLL.Contracts;
using Sgu.StudentTesting.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL
{
    public class RegisterLogic : IRegisterLogic
    {
        private readonly IRegisterDao _registerDao;

        public RegisterLogic(IRegisterDao registerDao)
        {
            _registerDao = registerDao;
        }

        public IEnumerable<City> GetCity()
        {
            return _registerDao.GetCity();
        }
        public IEnumerable<University> GetUniversity()
        {
            return _registerDao.GetUniversity();
        }
        public IEnumerable<Faculty> GetFaculty()
        {
            return _registerDao.GetFaculty();
        }
        public IEnumerable<Direction> GetDirection()
        {
            return _registerDao.GetDirection();
        }
    }
}
