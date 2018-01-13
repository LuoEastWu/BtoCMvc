using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luo.BLL
{
    public partial class CodeFirstTable:IBLL.CreateTable
    {
        public IDAL.CodeFirstTable codeFirst = new DAL.CodeFirstTable();

        public void CoderCreateTable()
        {
            codeFirst.Create();
        }

      
    }
}
