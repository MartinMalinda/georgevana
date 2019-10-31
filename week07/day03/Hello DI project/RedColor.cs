using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_DI_project
{
    public class RedColor : IColor
    {
        private readonly Printer printer;

        public RedColor(Printer printer)
        {
            this.printer = printer;
        }

        public void PrintColor()
        {
            printer.Log("It is red in color");
        }
    }
}
