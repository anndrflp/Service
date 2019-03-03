using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constants
{
    public static class TcConstants
    {
        public static class TcConstantsCommandType
        {
            public const int Create = 1;
            public const int Alter = 2;
            public const int AddColumn = 3;
            public const int Drop = 4;
        }
    }
}
