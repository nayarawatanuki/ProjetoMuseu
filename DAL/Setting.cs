using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Setting
    {
        public static string StrConnection
        {
            get => "server = localhost; DataBase = museu; Uid = root; Pwd = secret18; Connect Timeout = 30";
            //get => "server = localhost; DataBase = museu; Uid = root; Pwd = ifsp; Connect Timeout = 30";
        }
    }
}
