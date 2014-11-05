using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1SQL.dao
{
    public interface IDB
    {
        DataTable dataTable(string sql);
        DataSet dataSet(string sql);
        int executeNoQuery(string sql);
        Object executeScalar(string sql);
    }
}
