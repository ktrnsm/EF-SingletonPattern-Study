using EF_SingletonPattern_Study.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SingletonPattern_Study.DesignPatterns.SingletonPattern
{
    public class DBTool
    {

        DBTool() { }

        static NorthwindEntities _dbInstance;

        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}
