using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_DI_project
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is red in color");
        }
    }
}
