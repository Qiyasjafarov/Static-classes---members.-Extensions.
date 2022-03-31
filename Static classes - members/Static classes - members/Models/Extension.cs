using System;
using System.Collections.Generic;
using System.Text;

namespace Static_classes___members_.Models
{
    public static class Extension
    {public static int MPower(this int a)
        {
             int res = 1;
            
            for (int i = 0; i <a; i++)
            {
                res *= a;
            }
            return res;
        }
    }
}
