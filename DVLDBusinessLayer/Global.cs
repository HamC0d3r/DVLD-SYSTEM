using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class Global
    {
        public static clsUsers CurrentUser = clsUsers.FindUserByUserNameAndPass("","");
    }
}
