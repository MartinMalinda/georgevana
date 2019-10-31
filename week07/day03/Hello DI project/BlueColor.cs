using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_DI_project
{
    public class BlueColor : IColor
    {
        void IColor.PrintColor()
        {
            Console.WriteLine("It is blue in color");
        }
    }
}
