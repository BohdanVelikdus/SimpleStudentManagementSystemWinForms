using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velikdus_USOS.Interface
{
    public interface IBasicInfo
    {
        string FirstName { get; }
        string LastName { get; }
        int Age {  get; }
        bool Sex { get; }
        List<string> GetInfo();
    }



}
