using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class LoanMapper : IobjectMapper
    {
        BaseClass IobjectMapper.BuildObject(Dictionary<string, object> objectRow)
        {
            var loan = new Loan();
            {
                Id = int.Parse(objectRow["Id"]).ToString,
                type = objectRow["type"].ToString(),
                Abstract = objectRow["Abstract"].ToString(),
                PublishedDate = DateTime.Parse(objectRow["DatePublished"].ToString())
            };



        }
        }

        List<BaseClass> IobjectMapper.BuildObjects(List<Dictionary<string, object>> objectRows)
        {
            throw new NotImplementedException();
        }
    }
}
