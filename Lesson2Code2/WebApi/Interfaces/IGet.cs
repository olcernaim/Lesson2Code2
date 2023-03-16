using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Code2.WebApi.Interfaces
{
    public interface IGet
    {
        List<Person> Get();
        Person GetById(int id);
    }
}
