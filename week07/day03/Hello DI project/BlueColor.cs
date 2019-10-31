using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_DI_project
{
    public class BlueColor : IColor
    {
        private readonly Printer printer;

        public BlueColor(Printer printer)
        {
            this.printer = printer;
        }

        public void PrintColor()
        {
            printer.Log("It is blue in color");
        }
    }
}
