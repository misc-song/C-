using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    interface 
    class Program1
    {
        
        public static int main()
        {
            {
                for (int i = 0; i <= 1000; i++)
                {
                    if (i == 1000)
                    {
                        return 0;
                    }
                    else
                    {
                        return main();
                    }
                }
            }


            return 0;
        }
    }
}
