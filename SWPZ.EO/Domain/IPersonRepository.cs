using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPZ.EO.Domain
{
    public interface IPersonRepository
    {
        Person Load(int personId);
    }
}
