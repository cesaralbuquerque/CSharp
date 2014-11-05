using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1SQL.dao
{
    public static class DBFactory
    {
        public static IDB CreateSQLData()
        {
            return new SQLDataBase();
        }

    }
}
