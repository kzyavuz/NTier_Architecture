using Project_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BLL.DesignPattems.SinglatonPattern
{
    public class DBTool
    {
        DBTool() { }

        static MyContext _myContext;

        public static MyContext MyContext
        {
            get
            {
                if(_myContext == null) _myContext = new MyContext();
                return _myContext;
            }
        }
    }
}
