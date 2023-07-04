using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccess.Mapper
{
    public interface IobjectMapper
    {
        BaseClass BuildObject(Dictionary<string, object> objectRow);
        
        List<BaseClass> BuildObjects(List<Dictionary<string, object>> objectRows);
    }
}
