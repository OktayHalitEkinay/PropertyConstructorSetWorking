using ClassLibrary.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class EntityManager
    {
        public Result Add()
        {
            return new Result("Başarılı.",true);
        }
    }
}
