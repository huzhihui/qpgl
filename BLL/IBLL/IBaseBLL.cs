using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL.IBLL
{
    public interface IBaseBLL<T>
    {
        int doInsert(T inVo);
        int doUpdate(T inVo);
        int doDelete(T inVo);
        DataTable getTable(T inVo);

    }
}
