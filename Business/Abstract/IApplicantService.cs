using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        public void ApplyForMask(Person person);
        List<Person> GetList(Person person);

        bool CheckPerson(Person person);
    }
}
