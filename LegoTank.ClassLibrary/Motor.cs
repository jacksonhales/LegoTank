using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lego.Ev3.Core;

namespace LegoTank.ClassLibrary
{
    public class Motor
    {
        private OutputPort outputPort;

        public OutputPort OutputPort
        {
            get { return outputPort; }
            set { outputPort = value; }
        }

        public Motor(OutputPort pOutputPort)
        {
            outputPort = OutputPort;
        }


    }
}
